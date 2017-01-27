using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LipService.ViewModel {
    class CreateAccountViewModel {

        public CreateAccountViewModel (){
            //CreateAccountCommand = new Command();
        }

        public Command CreateAccountCommand { get; }

        public string Name { get; set; }
        public string Password { get; set; }

        //TODO: create a CreateAccount() method for command to instantiate
    }
}
