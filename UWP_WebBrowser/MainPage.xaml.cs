using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.WebUI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Dokumentaci k šabloně položky Prázdná stránka najdete na adrese https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x405

namespace UWP_WebBrowser
{
    /// <summary>
    /// Prázdná stránka, která se dá použít samostatně nebo v rámci objektu Frame
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (WebView2.CanGoBack)
            {
                WebView2.GoBack();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (WebView2.CanGoForward)
            {
                WebView2.GoForward();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(ab.Text))
            {
                Console.WriteLine("String = empty/null");
            }
            else
            {
                Uri value = new UriBuilder(ab.Text).Uri;
                WebView2.Source = value;
            }
        }
        private void WebView2_NavigationCompleted(WebView2 sender, CoreWebView2NavigationCompletedEventArgs args)
        {
            // Aktualizovat adresní řádek po každé dokončené navigaci
            ab.Text = WebView2.Source.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Uri HS = new UriBuilder("https://google.com").Uri;
            WebView2.Source = HS;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WebView2.Reload();
        }

        private void gab_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                string txt = "https://google.com/search?q="+gab.Text;
                Uri GSU = new UriBuilder(txt).Uri;
                WebView2.Source = GSU;

            }
        }
    }
}
