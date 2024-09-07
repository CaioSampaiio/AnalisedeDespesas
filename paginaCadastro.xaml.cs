//using static Android.Bluetooth.BluetoothClass.Device;
//using static Android.Provider.Contacts.Intents;

namespace AnalisedeDespesas;

public partial class paginaCadastro : ContentPage
{
    public paginaCadastro()
    {
        InitializeComponent();
    }

    private async void btnCad(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;
        

        if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
        {
            Tremer(50);

            async void Tremer(uint tempo)
            {
                await UsernameFrame.TranslateTo(-15, 0, tempo);
                await UsernameFrame.TranslateTo(10, 0, tempo);
                await UsernameFrame.TranslateTo(-5, 0, tempo);
                await UsernameFrame.TranslateTo(5, 0, tempo);
                UsernameFrame.TranslationX = 0;

                await EmailFrame.TranslateTo(-15, 0, tempo);
                await EmailFrame.TranslateTo(10, 0, tempo);
                await EmailFrame.TranslateTo(-5, 0, tempo);
                await EmailFrame.TranslateTo(5, 0, tempo);
                EmailFrame.TranslationX = 0;

                await PasswordFrame.TranslateTo(-15, 0, tempo);
                await PasswordFrame.TranslateTo(10, 0, tempo);
                await PasswordFrame.TranslateTo(-5, 0, tempo);
                await PasswordFrame.TranslateTo(5, 0, tempo);
                PasswordFrame.TranslationX = 0;
            }

            await DisplayAlert("Erro", "Por favor preencha todos os campos!", "OK");


        }
        else
        {
            if (username != "caio" && email != "caio@hotmail.com" && password != "1234")
            {
                await DisplayAlert("Erro", "Cadastro realizado com sucesso!", "OK");
            }
            else
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}