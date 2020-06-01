using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BoothCsvConverter.Models.Csv
{
    internal static class CsvWriter
    {
        public static void Write<T>(string path, IEnumerable<T> records)
            where T : ICsvModel
        {
            using var writer = new StreamWriter(path, false, EncodesResolver.Resolve<T>());
            using var csvWriter = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(records);
        }
    }
}
