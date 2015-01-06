using System;
using Xamarin.Forms;

namespace PTAndroidApp
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new StackLayout { 
				Content = new Label {
					Text = "Hello, Forms!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}

