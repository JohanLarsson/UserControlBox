namespace UserControlBox
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public static readonly DependencyProperty UriProperty = DependencyProperty.Register(
            "Uri", typeof (Uri), typeof (UserControl1), new PropertyMetadata(default(Uri)));

        public UserControl1()
        {
            InitializeComponent();
        }

        public Uri Uri
        {
            get { return (Uri)GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }
    }
}
