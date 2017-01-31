using System;
using System.Collections.Generic;
using LipService.ViewModel;
using Xamarin.Forms;
using LipService.View;

namespace LipService {
	public partial class LoginPage : ContentPage {
		public LoginPage() {
			InitializeComponent();
		}

		async void CreateAccountButton_Clicked(object sender, System.EventArgs e) {
			await Navigation.PushAsync(new CreateAccountPage());
		}
	}
}
