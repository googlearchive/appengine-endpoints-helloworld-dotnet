/*
Copyright 2014 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

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
        }

        // [START authgreet]
        /// <summary>Auth Greets the user using the Hello World service.</summary>
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

        // [START list]
        /// <summary>Lists all the Hello World's greetings.</summary>
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
            // [START execute]
            var response = await service.Greetings.ListGreeting().ExecuteAsync();
            // [END execute]

            // Update a UI control with the response.
            ResponseTextBlock.Text = String.Join(Environment.NewLine,
                from item in response.Items
                select item.Message);
        }
        // [END list]

        // [START greet]
        /// <summary>Greets the user using the Hello World service.</summary>
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
    }
}
