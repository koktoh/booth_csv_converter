using System.Collections.Generic;
using BoothCsvConverter.Models.Csv;

namespace BoothCsvConverter.Models.Convert
{
    internal interface IConverter<T>
        where T : ICsvModel
    {
        IEnumerable<T> Convert(IEnumerable<BoothCsvModel> records);

    }
}
