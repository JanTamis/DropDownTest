using System.Collections.Generic;

namespace ComboBoxTest.ViewModels;

public class MainWindowViewModel
{
	public IEnumerable<string> Data
	{
		get
		{
			yield return "hello";
			yield return "world";
		}
	}

	public string CurrentItem { get; set; }
}