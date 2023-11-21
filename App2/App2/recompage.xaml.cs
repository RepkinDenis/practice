using System;
using Xamarin.Forms;

namespace App2
{
    public partial class recompage : ContentPage
    {
        public recompage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            // создание таблицы, если ее нет
            await App.Database.CreateTable();
            // привязка данных
            recomList.ItemsSource = await App.Database.GetItemsAsync();

            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            recommend selectedRecom = (recommend)e.SelectedItem;
            RecommendPage recPage = new RecommendPage();
            recPage.BindingContext = selectedRecom;
            await Navigation.PushAsync(recPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateRecom(object sender, EventArgs e)
        {
            recommend friend = new recommend();
            RecommendPage recPage = new RecommendPage();
            recPage.BindingContext = friend;
            await Navigation.PushAsync(recPage);
        }
    }
}
