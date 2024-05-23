using System.Net.Sockets;

namespace MauiAppCrud.Views;

public partial class loginPage : ContentPage
{
	public loginPage()
	{
		InitializeComponent();
        //MainPage = new AppShell();

    }

    private  async void Button_Clicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (username == "h3nry" && password == "12345")
        {
            App.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }

    }

    private void cameraButton_Clicked(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        //registrarse
        await Navigation.PushAsync(new Views.registrarsePage());
    }
}