using System;
using Xamarin.Forms;

namespace fei13
{
	public class ContentDemoPage:ContentPage
	{
		public ContentDemoPage ()
		{
			Label lab1 = new Label ();
			lab1.Text = "lba1";
			lab1.Font = Font.SystemFontOfSize (40);
			lab1.HorizontalOptions = LayoutOptions.Center;

			Label lab2 = new Label ();
			lab2.Text = "lba2";
			lab2.TextColor = Color.Red;
			lab2.Font = Font.SystemFontOfSize (40);
			lab2.HorizontalOptions = LayoutOptions.Start;

			this.Content = new StackLayout {
				Children = { lab1, lab2 }
			};
			this.Title = "Content页";
		}
	}
}

