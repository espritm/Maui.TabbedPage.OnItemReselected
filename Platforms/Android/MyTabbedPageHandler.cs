using System;
namespace Maui.TabbedPage.OnItemReselected
{
    public partial class MyTabbedPageHandler : Microsoft.Maui.Handlers.TabbedViewHandler
    {
        protected override void ConnectHandler(Android.Views.View platformView)
        {
            base.ConnectHandler(platformView);

            AndroidX.ViewPager2.Widget.ViewPager2 platformview = platformView as AndroidX.ViewPager2.Widget.ViewPager2;

            //do something to get to the nativ bottomnavigationview and trigger onItemReselected
            //BottomNavigationBar.OnItemSelected => https://developer.android.com/reference/com/google/android/material/navigation/NavigationBarView#setOnItemSelectedListener(com.google.android.material.navigation.NavigationBarView.OnItemSelectedListener)
            //BottomNavigationBar.OnItemReselected => https://developer.android.com/reference/com/google/android/material/navigation/NavigationBarView.OnItemReselectedListener#summary
            //if selectedItemID != item.id > do nothing. we should trigger onitemreselected. => https://github.com/dotnet/maui/blob/0afc1c769e46b08530f1747344f70a95c56f8a31/src/Controls/src/Core/Platform/Android/TabbedPageManager.cs#L880C11-L880C11

            //Invoke this even when the native BottomNavigationBar.OnItemReselected is triggered
            OnReselectedCurrentTab?.Invoke(this, new EventArgs());
        }
    }
}
