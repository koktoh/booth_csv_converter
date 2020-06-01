using System.Collections.Generic;
using System.Linq;
using BoothCsvConverter.Models.Csv;

namespace BoothCsvConverter.Models.Convert
{
    internal class ClickPostConverter : IConverter<ClickPostCsvModel>
    {
        public IEnumerable<ClickPostCsvModel> Convert(IEnumerable<BoothCsvModel> records)
        {
            return records.Select(x =>
             {
                 var dest = new ClickPostCsvModel(x)
                 {
                     NameSuffix = "様"
                 };

                 var item = x.Item.Split('/').Last();

                 dest.Item = item.Length <= 15 ? item : item.Substring(0, 15);

                 return dest;
             });
        }
    }
}
