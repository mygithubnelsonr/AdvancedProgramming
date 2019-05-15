using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for Sample2.xaml
    /// </summary>
    public partial class Sample3 : Window
    {
        public Sample3()
        {
            InitializeComponent();
        }

        //// with await to get the html string
        //private async void ButtonTest_Click(object sender, RoutedEventArgs e)
        //{
        //    var html = await GetHtmlAsync("https://msdn.microsoft.com");
        //    LabelStatus.Content = "finish";

        //    MessageBox.Show(html.Substring(0, 20));
        //}

        // get the task object first
        private async void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            var getHtmlTask = GetHtmlAsync("https://msdn.microsoft.com");
            // here can be some code that is not depended on the result e.g.
            MessageBox.Show("Waiting for the task to complete.");

            var html = await getHtmlTask;
            LabelStatus.Content = "finish";

            MessageBox.Show(html.Substring(0, 20));
        }

        // with async
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            await Task.Delay(5000);
            return await webClient.DownloadStringTaskAsync(url);
        }

        // not async 
        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

    }
}
