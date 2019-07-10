using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            //Routing.RegisterRoute("moviedetail", typeof(DetailMovieView));
            //Routing.RegisterRoute("seriesdetail", typeof(DetailSerieView));
            //Routing.RegisterRoute("seasonsdetail", typeof(DetailSeasonSerieView));
            Routing.RegisterRoute("about", typeof(AboutUsView));
            Routing.RegisterRoute("acknowledgement", typeof(AcknowledgeView));
        }
    }
}