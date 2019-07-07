using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.ViewModels.Base;

namespace XamaFilm.ViewModels
{
    public class DetailSerieViewModel : ViewModelBase
    {
        public DetailSerieViewModel()
        {

        }

        private Serie _serie;
        public Serie Item
        {
            get => _serie;
            set { SetProperty(ref _serie, value); }            
        }

        public async override Task InitializeAsync(object navigationData)
        {            
        }
    }
}
