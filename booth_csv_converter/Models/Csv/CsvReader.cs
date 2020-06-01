using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace BoothCsvConverter.Models.Csv
{
    internal static class CsvReader
    {
        public static IEnumerable<T> Read<T>(string path)
            where T : ICsvModel
        {
            using var reader = new StreamReader(path, EncodesResolver.Resolve<T>());
            using var csvReader = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture);
            return csvReader.GetRecords<T>().ToList();
        }
    }
}
