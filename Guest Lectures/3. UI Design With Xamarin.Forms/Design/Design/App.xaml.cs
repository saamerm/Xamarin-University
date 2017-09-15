using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Design
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();

			//MainPage = new NavigationPage (new FontsPage ());
			MainPage = new NavigationPage(new ColorPage());
		}
	}
}