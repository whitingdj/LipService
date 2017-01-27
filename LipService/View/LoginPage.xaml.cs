using System;
using System.Collections.Generic;
using LipService.ViewModel;
using Xamarin.Forms;

namespace LipService {
	public partial class LoginPage : ContentPage {
		public LoginPage() {
			InitializeComponent();

            BindingContext = new LoginPageViewModel(this.Navigation);
		}
	}
}
