using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System.Collections.Generic;
[UseTemplate, NavigatorTarget("/body2")]
public class Body2 : Panel
{
	public Panel InnerOptions { get; set; }
	public Body2()
	{
		for (int i = 1; i <= 100; i++)
		{
			var button = InnerOptions.Add.Button("test");
		}
	}
}
