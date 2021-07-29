using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SecurigeIconPack.Core;

namespace SecurigeIconPack
{

    public class SecurigeIcons : SecurigeIconPackBase
    {
        public static readonly DependencyProperty KindProperty
            = DependencyProperty.Register(nameof(Kind), typeof(SecurigeIconsKind), typeof(SecurigeIcons), new PropertyMetadata(default(SecurigeIconsKind), KindPropertyChangedCallback));
        private static void KindPropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                ((SecurigeIcons)dependencyObject).UpdateData();
            }
        }

        public SecurigeIconsKind Kind
        {
            get { return (SecurigeIconsKind)GetValue(KindProperty); }
            set { SetValue(KindProperty, value); }
        }
#if !(NETFX_CORE || WINDOWS_UWP)
        static SecurigeIcons()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SecurigeIcons), new FrameworkPropertyMetadata(typeof(SecurigeIcons)));
        }
#endif
        protected override void SetKind<TKind>(TKind iconKind)
        {

            this.SetCurrentValue(KindProperty, iconKind);
        }

        protected override void UpdateData()
        {
            if (Kind != default(SecurigeIconsKind))
            {
                string data = null;
                SecurigeIconsDataFactory.DataIndex.Value?.TryGetValue(Kind, out data);
                this.Data = data;
            }
            else
            {
                this.Data = null;
            }
        }
    }
}
