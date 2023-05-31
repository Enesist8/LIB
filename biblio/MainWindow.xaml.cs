using System.Windows;
using Newtonsoft.Json;
using USTALYAAA;
using UstalTheme;
using System;

namespace biblio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            Class1 class1 = new Class1();
            public MainWindow()
            {
                var d  = class1.D();
                InitializeComponent();
                vigruzka.Text = d;
            }

            private void s_Click(object sender, RoutedEventArgs e)
            {
                string s = vvod.Text;
                class1.S(s);
                Close();
            }

        private void But1_Click(object sender, RoutedEventArgs e)
        {

            App.Theme = "Dictionary1";
       
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "Dictionary2";
        }
    }
    }

/*var uri = new Uri("Dictionary1.xaml", UriKind.Relative);
ResourceDictionary resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
Application.Current.Resources.Clear();
Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);*/