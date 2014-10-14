using System;
using Xamarin.Forms;

namespace fei13
{
	public class MainDemo:TabbedPage
	{
		public MainDemo ()
		{
			this.Title = "TabbedPage";
	
			this.Children.Add (new Democontent("简单页"));
			this.Children.Add (new ContentDemoPage());
			this.Children.Add (new MasterDetailDemoPage());
		}
	}
	class Democontent:ContentPage{

		public Democontent(String s){
			Label header = new Label {
				Text = s,
				Font = Font.SystemFontOfSize (40),
				HorizontalOptions = LayoutOptions.Center
			};
			this.Content = new StackLayout {
				Children={header}
			};
			this.Title = s;
		}
	}
}

