using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assign1
{
    public partial class MainPage : ContentPage
    {
        public Employee employee { get; set; }
        public MainPage()
        {
            employee = new Employee();
            InitializeComponent();
            BindingContext = this;
        }

        private bool IsValid()
        {
            if (!(dayTime.IsChecked ^ evening.IsChecked)) return false;



            return true;
        }

        async private void AddClicked(object sender, EventArgs e)
        {
            var errorMessage = employee.IsValid();

            if(errorMessage != null)
            {
                await DisplayAlert("Alert", errorMessage, "OK");
                return;
            }

            Console.WriteLine(employee.Salary);
        }
    }
}
