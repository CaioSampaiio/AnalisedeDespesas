namespace AnalisedeDespesas;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
    private async void btnLogar(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Simples validação dos campos de entrada
        if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            Tremer(50);

            async void Tremer(uint tempo)
            {
                await UsernameFrame.TranslateTo(-15, 0, tempo);
                await UsernameFrame.TranslateTo(10, 0, tempo);
                await UsernameFrame.TranslateTo(-5, 0, tempo);
                await UsernameFrame.TranslateTo(5, 0, tempo);
                UsernameFrame.TranslationX = 0;

                await PasswordFrame.TranslateTo(-15, 0, tempo);
                await PasswordFrame.TranslateTo(10, 0, tempo);
                await PasswordFrame.TranslateTo(-5, 0, tempo);
                await PasswordFrame.TranslateTo(5, 0, tempo);
                PasswordFrame.TranslationX = 0;
            }

            await DisplayAlert("Erro", "Por favor insira o usuário e senha!", "OK");


        }
        else
        {
            if (username != "caio" && password != "1234")
            {
                await DisplayAlert("Erro", "Usuário ou senha incorretos!", "OK");
            }
            else
            {
                await Navigation.PushAsync(new paginaPrincipal());
            }

        }
    }

    private async void btnCadastrar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new paginaCadastro());
    }
}


