using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LipService.ViewModel;
using Xamarin.Forms;

namespace LipService.View {
    public partial class CreateAccountPage : ContentPage {
        public CreateAccountPage() {
            InitializeComponent();
            BindingContext = new CreateAccountViewModel();
        }
    }
}
