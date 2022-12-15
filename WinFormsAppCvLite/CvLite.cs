using BlazorAppCVLite.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using RazorClassLibraryCvLite;
using RazorClassLibraryCvLite.Pages;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace WinFormsAppCvLite
{
    public partial class CvLite : Form
    {
        public CvLite()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWindowsFormsBlazorWebView();
            serviceCollection.AddSingleton<WeatherForecastService>();
            serviceCollection.AddAuthorizationCore();


            InitializeComponent();

            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
        }
    }
}