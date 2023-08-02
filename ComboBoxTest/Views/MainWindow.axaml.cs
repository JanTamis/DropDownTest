using Avalonia.Controls;
using ComboBoxTest.ViewModels;

namespace ComboBoxTest.Views;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
		DataContext = new MainWindowViewModel();
	}
}