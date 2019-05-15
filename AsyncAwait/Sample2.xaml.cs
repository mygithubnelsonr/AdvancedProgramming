using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for Sample2.xaml
    /// </summary>
    public partial class Sample2 : Window
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            LabelStatus.Content = "downloading...";
            DownloadHtmlAsync("https://msdn.microsoft.com");
            LabelStatus.Content = "finish";
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamwriter = new StreamWriter("result.html"))
            {
                await streamwriter.WriteAsync(html);
            }
        }
    }
}
