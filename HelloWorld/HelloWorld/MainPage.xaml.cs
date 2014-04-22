using EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Microsoft.Phone.Controls;
using System;
using System.Linq;
using System.Threading;
using System.Windows;

namespace HelloWorld
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // [START list]
        private async void List_Click(object sender, RoutedEventArgs e)
        {
            // [START service]
            // Create the service.
            var service = new HelloworldService(new BaseClientService.Initializer()
                {
                    ApplicationName = "Endpoints Sample",
                });
            // [END service]

            // Execute the request.
            var response = await service.Greetings.ListGreeting().ExecuteAsync();

            // Update a UI control with the response.
            ResponseTextBlock.Text = String.Join(Environment.NewLine,
                from item in response.Items
                select item.Message);
        }
        // [END list]

        // [START greet]
        private async void Greet_Click(object sender, RoutedEventArgs e)
        {
            var service = new HelloworldService(new BaseClientService.Initializer()
                {
                    ApplicationName = "Endpoints Sample",
                });
            var response = await service.Greetings.GetGreeting(0).ExecuteAsync();
            ResponseTextBlock.Text = response.Message;
        }
        // [END greet]

        // [START authgreet]
        private async void AuthGreet_Click(object sender, RoutedEventArgs e)
        {
            // Get or create the user credentials.
            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = ClientSecretsConsts.ClientId,
                    ClientSecret = ClientSecretsConsts.ClientSecret,
                },
                new[] { HelloworldService.Scope.UserinfoEmail },
                "user",
                CancellationToken.None);

            // Create the service.
            var service = new HelloworldService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Endpoints Sample",
                });

            // Execute the request.
            var response = await service.Greetings.Authed().ExecuteAsync();

            // Update a UI control with the response.
            ResponseTextBlock.Text = response.Message;
        }
        // [END authgreet]

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}
