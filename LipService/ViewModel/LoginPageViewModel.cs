using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LipService.View;
using Xamarin.Forms;

namespace LipService.ViewModel {
	class LoginPageViewModel : IAccountService {

		public ICommand LoginAuthenticate { get; private set; }

		public LoginPageViewModel() {
			LoginAuthenticate = new Command(Authenticate);
		}

		void Authenticate(string username, string password) {

		}

		public void Create(User user) {
			throw new Exception("Not implemented");
		}
	}
}
