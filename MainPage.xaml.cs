using AppJogoDaForca.Repositories;
using AppJogoDaForca.Models;


namespace AppJogoDaForca
{

	public partial class MainPage : ContentPage
	{
		private Word _word;
		public MainPage()
		{
			InitializeComponent();

			var repository = new WordRepositories();
			_word = repository.GetRandomWord();
		}


		private void OnButtonClicked(object sender, EventArgs e)
		{
			string letter = ((Button)sender).Text;
		}
	}

}

