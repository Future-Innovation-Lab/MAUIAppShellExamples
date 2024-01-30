using UwcAppShellExample.Models;

namespace UwcAppShellExample;

[QueryProperty(nameof(Monkey), "Monkey")]
public partial class MonkeyPage : ContentPage
{
    private Monkey _monkey;
    public Monkey Monkey
    {
        get { return _monkey; }
        set
        {
            _monkey = value;
            OnPropertyChanged();
        }
    }

    public MonkeyPage()
	{
		InitializeComponent();

        BindingContext = this;


	}
}