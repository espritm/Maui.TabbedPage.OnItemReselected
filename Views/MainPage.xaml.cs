namespace Maui.TabbedPage.OnItemReselected;

public partial class MainPage : MyTabbedPage
{
	public MainPage()
	{
		InitializeComponent();

        this.CurrentPageChanged += (s, a) =>
        {
            //Do something when user clicks on Tab1, then on Tab2, etc
        };
    }

    protected override async void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        MyTabbedPageHandler handler = this.Handler as MyTabbedPageHandler;

        if (handler != null)
        {
            handler.OnReselectedCurrentTab += (s, a) =>
            {
                //Do something in the code behind when user clicks on Tab1, then on Tab1, then on Tab1 again, etc
                //Think about creating a binding command for viewmodel usage
            };
        }
    }
}


