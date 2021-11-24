using Sandbox.UI;
using Sandbox.UI.Construct;
using System.Collections.Generic;


[UseTemplate]
public partial class Editor : Panel
{

	public static Editor Current;

	// Static variables
	public static bool IsOpen = false;

	public Editor()
	{
		Current = this;
	}
}

