using Microsoft.Extensions.DependencyInjection;

namespace CITA_355_Maui_Practice_Week_11;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}