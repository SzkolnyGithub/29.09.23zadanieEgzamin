namespace domekWgorachBadowski4c;

public partial class MainPage : ContentPage
{

	int x = 0;

	public MainPage()
	{
		InitializeComponent();

	}

	private void dodaj(object sender, EventArgs e)
	{
		x++;
		polubienia.Text = x + " polubień";
	}
    private void odejmij(object sender, EventArgs e)
    {
        x--;
		if(x < 0)
		{
			x = 0;
		}
        polubienia.Text = x + " polubień";
    }
}

