namespace _29._09._23Badowski4c;

public partial class MainPage : ContentPage
{
	int x = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void zmienWielkosc(object sender, ValueChangedEventArgs e)
	{
		double wielkosc = 0;
		wielkosc = slider1.Value;
		tuRozmiar.Text = "Rozmiar: " + Math.Round(wielkosc, 0);
		wynik.FontSize = wielkosc;
	}
	private void zmien(object sender, EventArgs e)
	{
        string[] napisy;
        napisy = new string[3];
        napisy[0] = "Good morning";
        napisy[1] = "Buenos dias";
        napisy[2] = "Dzień dobry";

		if(x > 2)
		{
			x = 0;
		}

		if (x == 0)
		{
			wynik.Text = napisy[0];
		} else if (x == 1)
		{
            wynik.Text = napisy[1];
        } else if (x == 2)
		{
            wynik.Text = napisy[2];
        }
		x++;
    }
}

