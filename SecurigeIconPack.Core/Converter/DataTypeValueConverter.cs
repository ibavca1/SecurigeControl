using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SecurigeIconPack.Core.Converter
{
    public class DataTypeValueConverter : MarkupConverter
    {
        private static DataTypeValueConverter _instance;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static DataTypeValueConverter()
        {
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ?? (_instance = new DataTypeValueConverter());
        }

        protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.GetType();
        }

        protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
