using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Homework1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsWindow : ContentPage
	{
		public SettingsWindow ()
		{
			InitializeComponent ();
		}

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            await btnSave.TranslateTo(0, 10, 100);
            await btnSave.TranslateTo(0, 0, 100, Easing.SinOut);

            await DisplayAlert("Alert", "Data has been Saved", "Okay");
        }
    }
}