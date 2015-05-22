// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HeadForSuccess
{
	[Register ("ViewController1")]
	partial class ViewController1
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton aButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton GoSetPos { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Label1 { get; set; }

		[Action ("InitialActionCompleted:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void InitialActionCompleted (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (aButton != null) {
				aButton.Dispose ();
				aButton = null;
			}
			if (GoSetPos != null) {
				GoSetPos.Dispose ();
				GoSetPos = null;
			}
			if (Label1 != null) {
				Label1.Dispose ();
				Label1 = null;
			}
		}
	}
}
