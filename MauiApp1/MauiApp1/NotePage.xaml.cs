using System.Runtime.CompilerServices;
namespace MauiApp1;

public partial class NotePage : ContentPage
{
	string content = "";
    string path = Path.Combine(FileSystem.AppDataDirectory, "note.txt");

    public NotePage()
	{
		InitializeComponent();
		if (File.Exists(path))
		{
			NomeArquivoEditor.Text = File.ReadAllText(path);
		}
		

	}

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		content = NomeArquivoEditor.Text;

		File.WriteAllText(path, content);
		DisplayAlert("Sucesso", "Arquivo salvo com sucesso", "OK");
	}

	private void DeleteButton_Clicked(Object sender, EventArgs e)
	{
		if (File.Exists(path)) { 
			File.Delete(path);
			DisplayAlert("Sucesso",$"Arquivo {NomeArquivoEditor.Text } deletado com sucesso","OK");
			NomeArquivoEditor.Text = " ";
			
		
		}
	}


	
}