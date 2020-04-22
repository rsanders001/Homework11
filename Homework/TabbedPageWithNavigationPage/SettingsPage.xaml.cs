using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}
		private void OnClicked(Object sender, EventArgs e)
		{
			if(Convert.ToInt32(age.Text) < 16)
			{
				Output.Text = "Too Young To Drive";
			}
			else
			{
				var ageNumber = Convert.ToInt32(age.Text) - 16;
				Output.Text = "You have been driving for " + ageNumber + "years";
			}
		}
	}
}

