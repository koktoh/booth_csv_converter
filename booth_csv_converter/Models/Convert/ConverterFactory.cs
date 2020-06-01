using BoothCsvConverter.Models.Csv;

namespace BoothCsvConverter.Models.Convert
{
    internal static class ConverterFactory
    {
        public static IConverter<T> Create<T>()
            where T : ICsvModel
        {
            if (typeof(T) == typeof(ClickPostCsvModel))
            {
                return (IConverter<T>)new ClickPostConverter();
            }
            else
            {
                return (IConverter<T>)new ClickPostConverter();
            }
        }
    }
}
