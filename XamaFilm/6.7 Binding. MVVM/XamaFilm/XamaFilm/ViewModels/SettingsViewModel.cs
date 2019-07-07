using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public ICommand NavigateToAcknowledgmentCommand => new Command(NavigateToAcknowledgmentCommandExecute);

        private async void NavigateToAcknowledgmentCommandExecute(object obj)
        {
            await Task.FromResult(true);
            //await NavigationService.NavigateToAsync(typeof(AcknowledgementViewModel), null);
        }

        public ICommand NavigateToAboutUsCommand => new Command(NavigateToAboutUsCommandExecute);

        private async void NavigateToAboutUsCommandExecute(object obj)
        {
            await Task.FromResult(true);
            //await NavigationService.NavigateToAsync(typeof(AboutUsViewModel), null);
        }
        public ICommand NavigateToPrivacyCommand => new Command(NavigateToPrivacyCommandExecute);

        private void NavigateToPrivacyCommandExecute(object obj)
        {
            Device.OpenUri(new Uri("http://www.riojadotnet.com"));
        }
    }
}
