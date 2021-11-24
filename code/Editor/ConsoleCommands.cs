using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
public partial class Editor
{
	[ClientCmd( "test" )]
	public static void OpenMenu()
	{
		Log.Info("test");
		IsOpen = !IsOpen;
		Current?.SetClass( "open", IsOpen );
	}
}
