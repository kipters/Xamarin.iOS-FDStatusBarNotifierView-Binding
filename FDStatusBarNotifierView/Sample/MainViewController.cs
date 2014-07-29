using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using Frankdilo.FDStatusBarNotifierView;

namespace Sample
{
	partial class MainViewController : UIViewController
	{
        private FDStatusBarNotifierView _view;

		public MainViewController (IntPtr handle) : base (handle)
		{
		}

        partial void ShowClick(UIButton sender)
        {
            HideClick(null);
            _view = new FDStatusBarNotifierView(MessageField.Text);
            _view.ShouldHideOnTap = HideOnTapSwitch.On;
            _view.ManuallyHide = false;
            _view.ShowAboveNavigationController(NavigationController);
        }

        partial void HideClick(UIButton sender)
        {
            if (_view != null)
                _view.Hide();
        }

        partial void ShowWithoutAutohideClick(UIButton sender)
        {
            HideClick(null);
            _view = new FDStatusBarNotifierView(MessageField.Text);
            _view.ShouldHideOnTap = HideOnTapSwitch.On;
            _view.ManuallyHide = true;
            _view.ShowAboveNavigationController(NavigationController);
        }
	}
}