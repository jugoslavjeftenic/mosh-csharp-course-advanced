using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace t02_10_Async
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

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //DownloadHtml("http://msdn.microsoft.com");
        //    //DownloadHtmlAsync("http://msdn.microsoft.com");

        //    var html = GetHtml("http://msdn.microsoft.com");
        //    MessageBox.Show(html[..20]);
        //}

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var html = await GetHtmlAsync("http://msdn.microsoft.com");
        //    MessageBox.Show(html[..20]);
        //}

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show("Waiting for the task to complete.");

            var html = await getHtmlTask;
            MessageBox.Show(html[..20]);
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            string htmlFile = @"E:\SDK-github\course-mosh\c# 3 - advanced\t02_10_Async\result.html";
            using var streamWriter = new StreamWriter(htmlFile);
            streamWriter.Write(html);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            string htmlFile = @"E:\SDK-github\course-mosh\c# 3 - advanced\t02_10_Async\result.html";
            using var streamWriter = new StreamWriter(htmlFile);
            await streamWriter.WriteAsync(html);
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
