using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            // Устанавливаем ширину бокового меню
            FlyoutWidth = 50;

            Items.Add(new FlyoutItem
            {
                // Указываем путь к иконке
                Icon = "icon_globe.png",
                Items = {
                    new Tab {
                        Items = { new ShellContent { Content = new ContentPage()} }
                    }
                }
            }) ;
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new StartPage()} }
                    }
                }
            });
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ContentPage()} }
                    }
                }
            });
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ContentPage()} }
                    }
                }
            });
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ContentPage()} }
                    }
                }
            });
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ContentPage()} }
                    }
                }
            });
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ContentPage()} }
                    }
                }
            });
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ContentPage()} }
                    }
                }
            });
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ContentPage()} }
                    }
                }
            });
            Items.Add(new FlyoutItem
            {
                Icon = "icon_globe.png",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ContentPage()} }
                    }
                }
            });
        }
    }
}
