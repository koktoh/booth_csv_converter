using System;
using System.Collections.Generic;
using System.Text;

namespace BoothCsvConverter.Models.Csv
{
    internal interface ICsvModel
    {
        public Encodes Encode { get; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Item { get; set; }
    }
}
