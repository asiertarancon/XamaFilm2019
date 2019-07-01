using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjConverters
{
    public enum Semaphore
    {
        green,
        yellow,
        red
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private Semaphore semaphoreValue;
        public Semaphore SemaphoreValue
        {
            get => semaphoreValue;
            set
            {
                semaphoreValue = value;
                OnPropertyChanged();
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (semaphoreValue == Semaphore.green)
                SemaphoreValue = Semaphore.yellow;
            else if (semaphoreValue == Semaphore.yellow)
                SemaphoreValue = Semaphore.red;
            else
                SemaphoreValue = Semaphore.green;


        }
    }
}
