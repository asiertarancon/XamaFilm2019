using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class LoginViewModel : BindableObject
    {
        private string _username;
        private string _password;
        private Command _sayHelloCommand;

        public LoginViewModel()
        {
            _sayHelloCommand = new Command(SayHelloExecute, SayHelloCanExecute);
        }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
                SayHelloCommand.ChangeCanExecute();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
                SayHelloCommand.ChangeCanExecute();
            }
        }

        public Command SayHelloCommand => _sayHelloCommand;

        private void SayHelloExecute()
        {
			Saludo = $"Bienvenido {Username}, con Password: {Password}";

			Application.Current.MainPage.DisplayAlert("Login", Saludo, "OK");
        }

        private bool SayHelloCanExecute()
        {
            return !string.IsNullOrWhiteSpace(_username);
        }

		private string _saludo;
		public string Saludo
		{
			get => _saludo;
			set
			{
				_saludo = value;
				OnPropertyChanged();
			}
		}
    }
}
