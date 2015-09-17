using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace MVVM.ViewModels.Converters
{
    public class BackgroundConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(value.ToString() == "male")
            {
                return new SolidColorBrush(new Windows.UI.Color()
                {
                    A = 255,
                    R = 27,
                    G = 161,
                    B = 226
                });
            }
            else
            {
                return new SolidColorBrush(new Windows.UI.Color()
                {
                    A = 255,
                    R = 216,
                    G = 0,
                    B = 115
                });
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
