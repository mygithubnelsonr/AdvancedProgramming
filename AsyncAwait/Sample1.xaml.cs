using System.IO;
using System.Net;
using System.Windows;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            LabelStatus.Content = "downloading...";
            DownloadHtml("https://msdn.microsoft.com");
            LabelStatus.Content = "finish";
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamwriter = new StreamWriter("result.html"))
            {
                streamwriter.Write(html);
            }
        }
    }
}
