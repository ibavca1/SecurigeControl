using System;
using System.Windows;
using static SecurigeControl.Core.PackIconContorlBase;

namespace SecurigeIconPack
{
    /// <summary>
    /// Выполните шаги 1a или 1b, а затем 2, чтобы использовать этот пользовательский элемент управления в файле XAML.
    ///
    /// Шаг 1a. Использование пользовательского элемента управления в файле XAML, существующем в текущем проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SecurigeIconPack"
    ///
    ///
    /// Шаг 1б. Использование пользовательского элемента управления в файле XAML, существующем в другом проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SecurigeControl;assembly=SecurigeControl"
    ///
    /// Потребуется также добавить ссылку из проекта, в котором находится файл XAML,
    /// на данный проект и пересобрать во избежание ошибок компиляции:
    ///
    ///     Щелкните правой кнопкой мыши нужный проект в обозревателе решений и выберите
    ///     "Добавить ссылку"->"Проекты"->[Поиск и выбор проекта]
    ///
    ///
    /// Шаг 2)
    /// Теперь можно использовать элемент управления в файле XAML.
    ///
    ///     <MyNamespace:SecurigeIconPack/>
    ///
    /// </summary>
    public class SecurigeIconPack : PackIconControlBase
    {
        private static void KindPropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                ((SecurigeIconPack)dependencyObject).UpdateData();
            }
        }
        public static readonly DependencyProperty KindProperty
            = DependencyProperty.Register(nameof(Kind), typeof(SecurigeIconPackKind), typeof(SecurigeIconPack), new PropertyMetadata(default(SecurigeIconPackKind), KindPropertyChangedCallback));
        public SecurigeIconPackKind Kind
        {
            get { return (SecurigeIconPackKind)GetValue(KindProperty); }
            set { SetValue(KindProperty, value); }
        }
        static SecurigeIconPack()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SecurigeIconPack), new FrameworkPropertyMetadata(typeof(SecurigeIconPack)));
        }

        protected override void SetKind<TKind>(TKind iconKind)
        {
            SetCurrentValue(KindProperty, iconKind);
        }

        protected override void UpdateData()
        {
            if (Kind != default(SecurigeIconPackKind))
            {
                string data = null;
                SecurigeIconPackDataFactory.DataIndex.Value?.TryGetValue(Kind, out data);
                Data = data;
            }
            else
            {
                Data = null;
            }
        }
    }
}
