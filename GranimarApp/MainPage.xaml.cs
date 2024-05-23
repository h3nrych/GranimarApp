using MauiAppCrud.ViewModels;


namespace MauiAppCrud
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private  async void Button_Clicked_1(object sender, EventArgs e)
        {
            //iniciar sesion
            await Navigation.PushAsync(new Views.loginPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.info());

        }
    }
}