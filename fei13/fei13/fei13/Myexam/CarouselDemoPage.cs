using System;
using Xamarin.Forms;

namespace fei13
{
	public class CarouselDemoPage:CarouselPage
	{
		public CarouselDemoPage ()
		{
			Children.Add (new ContentPage {Content = new BoxView {Color = new Color (1, 0, 0)},
				Title = "Page 1"});
			Children.Add (new ContentPage {Content = new BoxView {Color = new Color (0, 1, 0)},
				Title = "Page 2"});
			Children.Add (new ContentPage {Content = new BoxView {Color = new Color (0, 0, 1)},
				Title = "Page 3"});
			Title = "Carouse页";
		}
	}
}

