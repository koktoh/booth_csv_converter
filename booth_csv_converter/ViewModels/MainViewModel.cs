using System.IO;
using System.Linq;
using System.Windows;
using BoothCsvConverter.Models.Convert;
using BoothCsvConverter.Models.Csv;
using GongSolutions.Wpf.DragDrop;
using Prism.Commands;
using Prism.Mvvm;

namespace BoothCsvConverter.ViewModels
{
    internal class MainViewModel : BindableBase, IDropTarget
    {
        private string _srcPath;
        private string _destPath;
        private string _status;

        public string SrcPath
        {
            get { return this._srcPath; }
            set { SetProperty(ref this._srcPath, value); }
        }

        public string DestPath
        {
            get { return this._destPath; }
            set { SetProperty(ref this._destPath, value); }
        }

        public string Status
        {
            get { return this._status; }
            set { SetProperty(ref this._status, value); }
        }

        public DelegateCommand RunCommand { get; private set; }

        public MainViewModel()
        {
            this.RunCommand = new DelegateCommand(this.Execute);
        }

        public void Execute()
        {
            this.Status = "Running...";

            var converter = ConverterFactory.Create<ClickPostCsvModel>();

            try
            {
                var src = CsvReader.Read<BoothCsvModel>(this.SrcPath);
                var dest = converter.Convert(src);
                CsvWriter.Write(this.DestPath, dest);
            }
            catch
            {
                this.Status = $"Error!";
                return;
            }

            this.Status = "Complete!";
        }

        public void DragOver(IDropInfo dropInfo)
        {
            var file = ((DataObject)dropInfo.Data).GetFileDropList().Cast<string>().FirstOrDefault();
            dropInfo.Effects = string.IsNullOrWhiteSpace(file) ? DragDropEffects.None : DragDropEffects.Copy;
        }

        public void Drop(IDropInfo dropInfo)
        {
            var file = ((DataObject)dropInfo.Data).GetFileDropList().Cast<string>().FirstOrDefault();

            if (string.IsNullOrWhiteSpace(file))
            {
                return;
            }

            this.SrcPath = file;
            this.DestPath = Path.Combine(Path.GetDirectoryName(file), "output.csv");
        }
    }
}
