namespace CITA_355_Maui_Practice_Week_11;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object? sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(nameEntry.Text))
		{
			resultLabel.Text = "Please enter your name.";
		}
		else
		{
			resultLabel.Text = $"Hello, {nameEntry.Text}!";
		}
	}

	private void OnClearButtonClicked(object? sender, EventArgs e)
	{
		nameEntry.Text = string.Empty;
		resultLabel.Text = string.Empty;
	}
}
