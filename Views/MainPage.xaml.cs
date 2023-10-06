namespace Maui.TabbedPage.OnItemReselected;

public partial class MainPage : MyTabbedPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    protected override async void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        MyTabbedPageHandler handler = this.Handler as MyTabbedPageHandler;

        if (handler != null)
        {
            handler.OnReselectedCurrentTab += (s, a) =>
            {
                //Do something in the code behind.
                //Think about creating a binding command for viewmodel usage
            };
        }
    }
}


