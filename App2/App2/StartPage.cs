using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2
{
    class StartPage : ContentPage
    {
        public StartPage()
        {
            Button alertButton = new Button
            {
                Text = "Alert",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };
            alertButton.Clicked += AlertButton_Clicked;

            Content = alertButton;
        }

        private void AlertButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Уведомление", "Пришло новое сообщение", "ОK");
        }
    }
}
