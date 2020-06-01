using System;
using CsvHelper.Configuration.Attributes;

namespace BoothCsvConverter.Models.Csv
{
    internal class BoothCsvModel : CsvModelBase
    {
        [Ignore]
        public override Encodes Encode { get; } = Encodes.UTF8;

        [Index(0)]
        public string OrderId { get; set; }
        [Index(1)]
        public string UserCode { get; set; }
        [Index(2)]
        public string Payment { get; set; }
        [Index(3)]
        public string OrderState { get; set; }
        [Index(4)]
        public string OrderDate { get; set; }
        [Index(5)]
        public string PaymentDate { get; set; }
        [Index(6)]
        public string SendDate { get; set; }
        [Index(7)]
        public string TotalPayment { get; set; }
        [Index(8)]
        public override string PostCode { get; set; }
        [Index(9)]
        public override string Address1 { get; set; }
        [Index(10)]
        public override string Address2 { get; set; }
        [Index(11)]
        public override string Address3 { get; set; }
        [Index(12)]
        public override string Name { get; set; }
        [Index(13)]
        public override string PhoneNumber { get; set; }
        [Index(14)]
        public override string Item { get; set; }

        #region for interface

        [Ignore]
        public override string Address4 { get; set; }
        [Ignore]
        public override string Address5 { get; set; }

        #endregion

        public BoothCsvModel() : base() { }
        public BoothCsvModel(ICsvModel csvModel) : base(csvModel) { }
    }
}
