using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlexLayoutPage : ContentPage
	{
		public FlexLayoutPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            FlexLayout.Direction = FlexDirection.Column;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            FlexLayout.Direction = FlexDirection.Row;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {            
            FlexLayout.Wrap = FlexLayout.Wrap == FlexWrap.Wrap ? FlexWrap.NoWrap : FlexWrap.Wrap;
            WrapButton.Text = FlexLayout.Wrap.ToString();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            FlexLayout.AlignItems = FlexAlignItems.Center;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            FlexLayout.AlignItems = FlexAlignItems.Start;
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            FlexLayout.AlignItems = FlexAlignItems.End;
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            FlexLayout.JustifyContent = FlexJustify.Center;
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            FlexLayout.JustifyContent = FlexJustify.SpaceAround;
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            FlexLayout.JustifyContent = FlexJustify.SpaceEvenly;
        }
    }
}