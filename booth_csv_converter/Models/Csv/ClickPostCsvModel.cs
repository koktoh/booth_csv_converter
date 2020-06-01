﻿using System;
using CsvHelper.Configuration.Attributes;

namespace BoothCsvConverter.Models.Csv
{
    internal class ClickPostCsvModel : CsvModelBase
    {
        [Ignore]
        public override Encodes Encode { get; } = Encodes.ShiftJis;

        [Index(0)]
        [Name("お届け先郵便番号")]
        public override string PostCode { get; set; }
        [Index(1)]
        [Name("お届け先氏名")]
        public override string Name { get; set; }
        [Index(2)]
        [Name("お届け先敬称")]
        public string NameSuffix { get; set; }
        [Index(3)]
        [Name("お届け先住所1行目")]
        public override string Address1 { get; set; }
        [Index(4)]
        [Name("お届け先住所2行目")]
        public override string Address2 { get; set; }
        [Index(5)]
        [Name("お届け先住所3行目")]
        public override string Address3 { get; set; }
        [Index(6)]
        [Name("お届け先住所4行目")]
        public override string Address4 { get; set; }
        [Index(7)]
        [Name("内容品")]
        public override string Item { get; set; }

        #region for interface

        [Ignore]
        public override string Address5 { get; set; }
        [Ignore]
        public override string PhoneNumber { get; set; }

        #endregion

        public ClickPostCsvModel() : base() { }
        public ClickPostCsvModel(ICsvModel csvModel) : base(csvModel) { }
    }
}
