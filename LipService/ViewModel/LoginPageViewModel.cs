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
			
		}

		public void Authenticate(string username, string password) {
			throw new Exception("Not implemented");
		}

		public void Create(User user) {
			throw new Exception("Not implemented");
		}
	}
}
