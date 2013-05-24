using System;
using System.Collections.Generic;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Cytaty
{
	public sealed partial class MainPage
	{
		private readonly List<string> _quotes = new List<string>();
		private readonly Random _random = new Random();

		public MainPage()
		{
			InitializeComponent();
			AddQuotes();
			RandomQuote();
		}

		//Dodawanie wszystkich cytatów
		private void AddQuotes()
		{
			_quotes.Add("Cytat 1");
			_quotes.Add("Cytat 2");
			_quotes.Add("Cytat 3");
		}

		//Losowanie i wyświetlanie cytatu
		private void RandomQuote()
		{
			Quote.Text = _quotes[_random.Next(_quotes.Count)];
		}

		// Kliknięcie na cytat
		private void QuoteTapped(object sender, TappedRoutedEventArgs e)
		{
			RandomQuote();
		}

		// Kopiowanie cytatu do schowka
		private void CopyClick(object sender, RoutedEventArgs e)
		{
			var dp = new DataPackage();
			dp.SetText(Quote.Text);
			Clipboard.SetContent(dp);
		}

		//Losowanie po kliku
		private void NextQuoteClick(object sender, RoutedEventArgs e)
		{
			RandomQuote();
		}
	}
}