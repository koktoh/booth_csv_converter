using System;
using System.Collections.Generic;
using System.Text;

namespace BoothCsvConverter.Models.Csv
{
    internal abstract class CsvModelBase : ICsvModel
    {
        public abstract Encodes Encode { get; }
        public abstract string Name { get; set; }
        public abstract string PhoneNumber { get; set; }
        public abstract string PostCode { get; set; }
        public abstract string Address1 { get; set; }
        public abstract string Address2 { get; set; }
        public abstract string Address3 { get; set; }
        public abstract string Address4 { get; set; }
        public abstract string Address5 { get; set; }
        public abstract string Item { get; set; }

        public CsvModelBase() { }
        public CsvModelBase(ICsvModel csvModel)
        {
            this.Name = csvModel.Name;
            this.PhoneNumber = csvModel.PhoneNumber;
            this.PostCode = csvModel.PostCode;
            this.Address1 = csvModel.Address1;
            this.Address2 = csvModel.Address2;
            this.Address3 = csvModel.Address3;
            this.Address4 = csvModel.Address4;
            this.Address5 = csvModel.Address5;
            this.Item = csvModel.Item;
        }
    }
}
