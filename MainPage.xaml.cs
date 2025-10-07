using AppJogoDaForca.Repositories;
using AppJogoDaForca.Models;
using AppJogoDaForca.Libraries.Text;


namespace AppJogoDaForca
{

	public partial class MainPage : ContentPage
	{
		private Word _word;
		private int _errors;
		public MainPage()
		{
			InitializeComponent();

			ResetScreen();

		}


		private void OnButtonClicked(object sender, EventArgs e)
		{

			((Button)sender).IsEnabled = false;
			String letter = ((Button)sender).Text;

			var positions = _word.Text.GetPositions(letter);


			if (positions.Count == 0)
			{
				_errors++;
				ImgMain.Source = ImageSource.FromFile($"forca{_errors + 1}.svg");

				if (_errors == 6)
				{
					DisplayAlert("Perdeu!", "Você foi enforcado!", "Novo Jogo");

					ResetScreen();
				}

				return;
			}

			foreach (int position in positions)
			{
				LblText.Text = LblText.Text.Remove(position, 1).Insert(position, letter);

			}
		}

		private void ResetScreen()
		{
			_errors = 0;
			ImgMain.Source = ImageSource.FromFile("forca1.svg");

			var repository = new WordRepositories();
			_word = repository.GetRandomWord();

			LblTips.Text = _word.Tips;
			LblText.Text = new string('_', _word.Text.Length);
		}

	}

}

