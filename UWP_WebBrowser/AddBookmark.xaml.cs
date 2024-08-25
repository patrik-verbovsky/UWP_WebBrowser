using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Dokumentaci k šabloně Prázdná aplikace najdete na adrese https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_WebBrowser
{
    /// <summary>
    /// Prázdná stránka, která se dá použít samostatně nebo se na ni dá přejít v rámci
    /// </summary>
    public sealed partial class AddBookmark : Page
    {
        public AddBookmark()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = URLA.Text;

            if (!File.Exists(@"C:\Users\Public\bookmarks"))
            {
                File.Create(@"C:\Users\Public\bookmarks");
                if (url == "" || url == null)
                {
                    if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                    {
                        using (StreamWriter sw = new StreamWriter(@"C:\Public\bookmarks"))
                        {
                            sw.WriteLine(url);
                            sw.Close();
                            var dialog = new MessageDialog("Záložka byla přidána.");
                            dialog.ShowAsync();
                        }
                    }
                }
            } else
            {
                if (url == "" || url == null)
                {
                    if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                    {
                        using (StreamWriter sw = new StreamWriter(@"C:\Public\bookmarks"))
                        {
                            sw.WriteLine(url);
                            sw.Close();
                            var dialog = new MessageDialog("Záložka byla přidána.");
                            dialog.ShowAsync();
                        }
                    }
                }
            }

        }
    }
}
