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
	[Register ("ViewController3")]
	partial class ViewController3
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel CurrentPos { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel deg { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel ManualPos { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UINavigationBar NavBarPosition { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField Position { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SetPos { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CurrentPos != null) {
				CurrentPos.Dispose ();
				CurrentPos = null;
			}
			if (deg != null) {
				deg.Dispose ();
				deg = null;
			}
			if (ManualPos != null) {
				ManualPos.Dispose ();
				ManualPos = null;
			}
			if (NavBarPosition != null) {
				NavBarPosition.Dispose ();
				NavBarPosition = null;
			}
			if (Position != null) {
				Position.Dispose ();
				Position = null;
			}
			if (SetPos != null) {
				SetPos.Dispose ();
				SetPos = null;
			}
		}
	}
}
