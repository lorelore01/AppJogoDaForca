using AppJogoDaForca.Repositories;

namespace AppJogoDaForca
{

	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();

			var repository = new WordRepositories();
			_word = repository.GetRandomWord
		}

	}

}

