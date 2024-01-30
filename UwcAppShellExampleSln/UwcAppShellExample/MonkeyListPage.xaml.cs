using UwcAppShellExample.Interfaces;
using UwcAppShellExample.Models;
using UwcAppShellExample.Services;

namespace UwcAppShellExample;

public partial class MonkeyListPage : ContentPage
{
	

	public MonkeyListPage()
	{
		InitializeComponent();

		IMonkeyMaker maker = new MonkeyMaker();

		MonkeyListView.ItemsSource = maker.Monkeys;


    }

    private async void MonkeyListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		Monkey monkey = (Monkey) e.Item;

        var navigationParameter = new ShellNavigationQueryParameters
    {
        { "Monkey", monkey }
    };
    
        await Shell.Current.GoToAsync("monkeypage",navigationParameter);
    }

 
}