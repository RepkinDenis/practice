using System;
using Xamarin.Forms;

namespace App2
{
    public partial class RecommendPage : ContentPage
    {
        public RecommendPage()
        {
            InitializeComponent();
        }
        //обработка кнопок сохранить, удалить и отмена(но отмена это просто выкидывает на пред. страницу, можно убрать потом)
        private async void SaveRecom(object sender, EventArgs e)
        {
            var recomm = (recommend)BindingContext;
            if (!String.IsNullOrEmpty(recomm.name_place))
            {
                await App.Database.SaveItemAsync(recomm);
            }
            await this.Navigation.PopAsync();
        }
        private async void DeleteRecom(object sender, EventArgs e)
        {
            var recomm = (recommend)BindingContext;
            await App.Database.DeleteItemAsync(recomm);
            await this.Navigation.PopAsync();
        }
        private async void Cancel(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}
