using camara;

namespace MauiAppCrud.Views;

public partial class registrarsePage : ContentPage
{
	public registrarsePage()
	{
		InitializeComponent();
	}

    private async void OnCameraButtonClicked(object sender, EventArgs e)
    {
        try
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
                var imageSource = ImageSource.FromStream(() => stream);
                capturedImage.Source = imageSource;
                AppState.CapturedImage = imageSource; // Guarda la imagen capturada en un estado de la aplicación
            }
        }
        catch (FeatureNotSupportedException fnsEx)
        {
            // Handle not supported on device exception
        }
        catch (PermissionException pEx)
        {
            // Handle permission exception
        }
        catch (Exception ex)
        {
            // Handle other exceptions
        }
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.loginPage());
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {

        await DisplayAlert("Registro", "Registro exitoso", "OK");
        await Navigation.PushAsync(new Views.loginPage());


    }
}