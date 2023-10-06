using UIKit;

namespace Maui.TabbedPage.OnItemReselected
{
	public partial class MyTabbedPageHandler : Microsoft.Maui.Handlers.TabbedViewHandler
    {
        protected override UIView CreatePlatformView()
        {
            UIView result = new UIView();

            try
            {
                result = base.CreatePlatformView();
            }
            catch (NotImplementedException e)
            {
                System.Diagnostics.Debug.Write(e.Message);
                System.Diagnostics.Debug.Write(e.StackTrace);
                Application.Current.MainPage.DisplayAlert("Blank page", "MyTabbedPageHandler.CreatePlatformView() throw not implemented exception for iOS.", "OK");
            }

            return result;
        }
    }
}

