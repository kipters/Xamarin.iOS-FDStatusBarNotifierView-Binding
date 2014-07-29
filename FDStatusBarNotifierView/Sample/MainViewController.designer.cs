// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Sample
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch HideOnTapSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField MessageField { get; set; }

		[Action ("HideClick:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void HideClick (UIButton sender);

		[Action ("ShowClick:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowClick (UIButton sender);

		[Action ("ShowWithoutAutohideClick:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ShowWithoutAutohideClick (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (HideOnTapSwitch != null) {
				HideOnTapSwitch.Dispose ();
				HideOnTapSwitch = null;
			}
			if (MessageField != null) {
				MessageField.Dispose ();
				MessageField = null;
			}
		}
	}
}
