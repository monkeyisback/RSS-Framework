using CodeHollow.FeedReader;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

//using Ude;

namespace RSS_Framework
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Prout();
		}

		private async void Prout()
		{
			string url = "https://www.lemondeinformatique.fr/flux-rss/thematique/securite/rss.xml";
			//string url = "https://www.lemonde.fr/rss/une.xml";

			var feed = await FeedReader.ReadAsync(url);

			foreach (var item in feed.Items)
			{
				//MessageBox.Show(item.Title + " - " + item.Link);
			}
		}
	}
}