using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LipService.View;
using Xamarin.Forms;

namespace LipService.ViewModel {
    class LoginPageViewModel {

        private INavigation _navigation;

        public LoginPageViewModel(INavigation navigation) {
            _navigation = navigation;
            NavigateToCreateAccountPageCommand = new Command(async () => await CreateAccountButtonClicked());
        }

        public Command NavigateToCreateAccountPageCommand { get; }

        private async Task CreateAccountButtonClicked() {
            await _navigation.PushAsync(new CreateAccountPage());
        }
    }
}
