using System;
using System.Collections.Generic;
using System.Text;
using BoothCsvConverter.Models.Csv;

namespace BoothCsvConverter.Models
{
    internal enum Encodes
    {
        UTF8,
        ShiftJis,
    }

    internal static class EncodesResolver
    {
        private static readonly IReadOnlyDictionary<Encodes, Encoding> _encodesMap = new Dictionary<Encodes, Encoding>
        {
            { Encodes.UTF8, Encoding.UTF8 },
            { Encodes.ShiftJis, Encoding.GetEncoding("shift-jis") },
        };

        public static Encoding Resolve<T>()
            where T : ICsvModel
        {
            var encode = (Encodes)typeof(T).GetProperty("Encode").GetValue(Activator.CreateInstance<T>());

            if (_encodesMap.TryGetValue(encode, out var value))
            {
                return value;
            }
            else
            {
                return Encoding.UTF8;
            }
        }
    }
}
