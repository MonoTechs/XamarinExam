using System;
using Xamarin.Forms;

namespace fei13
{
	public class MasterDetailDemoPage:MasterDetailPage
	{
		public MasterDetailDemoPage ()
		{
			Label header = new Label ();
			header.Text = "我的master detail 页";

			String[] namedColor = { 
				"红色","绿色","棕色","蓝色","黑色"			
			};

			ListView lview = new ListView{
				ItemsSource=namedColor
			};

			ContentPage ctnt = new ContentPage {
				Content=new StackLayout{
					Children={header,lview}
				},
				Title="content page"
			};

			ContentPage dcontnt = new ContentPage{ 
				Content=new Label (){ Text="11"}
			};
	
			Title = "MasterDetail页";
			Master = ctnt;
			IsPresented = true;
			Detail = dcontnt;
		}
	}
}

