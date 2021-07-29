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
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SecurigeIconPack"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SecurigeIconPack;assembly=SecurigeIconPack"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:SecurigeIcons/>
    ///
    /// </summary>
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
