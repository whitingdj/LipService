using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LipService {
	public partial class HomePage : TabbedPage {
		public HomePage() {
			InitializeComponent();
		}
		protected override void OnAppearing() {
			base.OnAppearing();

			if (!App.Instance.IsAuthenticated) {
				Navigation.PushModalAsync(new LoginPage());
			}
		}
	}
}
