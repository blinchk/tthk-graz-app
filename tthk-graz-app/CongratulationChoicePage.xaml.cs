using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tthk_graz_app
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CongratulationChoicePage : ContentPage
    {
        public CongratulationChoicePage(string communicationTool)
        {
            InitializeComponent();
        }
    }
}