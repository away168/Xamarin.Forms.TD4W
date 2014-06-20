using System;
using Xamarin.Forms;

namespace TD4WApp {
	public class App {
		public static Page GetMainPage ()
		{	
			var button = new Button {
				Text = "TD4W",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				HeightRequest = 200,
				WidthRequest = 200,
				BackgroundColor = Color.White,
				TextColor = Color.Black,
			};
			button.Clicked += (sender, e) =>
			{
				DependencyService.Get<IPlayer>().Play(0);
			};

			var ateam = new Button {
				Text = "A-Team",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				HeightRequest = 200,
				WidthRequest = 200,
				BackgroundColor = Color.Green,
				TextColor = Color.Black,
			};

			ateam.Clicked += async (sender, e) =>
			{
				DependencyService.Get<IPlayer> ().Play (1);
			};


			return new ContentPage { 
				Content = new StackLayout
				{
					Spacing = 5,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = 
					{
						button,
						ateam,
					}
				},
				BackgroundColor = Color.Black,
			};
		}
	}
}

