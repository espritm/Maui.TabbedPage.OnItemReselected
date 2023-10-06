namespace Maui.TabbedPage.OnItemReselected;

public partial class TabPage : ContentPage
{
    int count = 0;

    public TabPage()
	{
		InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}
