using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Frankdilo.FDStatusBarNotifierView
{
    [BaseType(typeof(UIView), Delegates = new string[] { "WeakDelegate" }, Events = new Type[] { typeof(FDStatusBarNotifierViewDelegate) })]
    interface FDStatusBarNotifierView
    {
        [Export("message")]
        string Message { get; set;}

        [Export("shouldHideOnTap")]
        bool ShouldHideOnTap{get;set;}

        [Export("manuallyHide")]
        bool ManuallyHide{get;set;}

        [Export("timeOnScreen")]
        TimeSpan TimeOnScreen{get;set;}

        [Export("isHidden")]
        bool IsHidden{ get;}

        [Export("delegate", ArgumentSemantic.Assign)][NullAllowed]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")][NullAllowed]
        FDStatusBarNotifierViewDelegate Delegate { get; set; }

        [Export("initWithMessage:")]
        IntPtr Constructor(string message);

        [Export("initWithMessage:delegate:")]
        IntPtr Constructor(string message, FDStatusBarNotifierViewDelegate fdStatusBarNotifierViewDelegate);

        [Export("showInWindow:")]
        void ShowInWindow(UIWindow window);

        [Export("showAboveNavigationController:")]
        void ShowAboveNavigationController(UINavigationController navigationController);

        [Export("hide")]
        void Hide();
    }

    [BaseType(typeof(NSObject))]
    [Model]
    [Protocol]
    interface FDStatusBarNotifierViewDelegate
    {
        [Export("willPresentNotifierView:")]
        void WillPresent(FDStatusBarNotifierView notifierView);
        [Export("didPresentNotifierView:")]
        void DidPresent(FDStatusBarNotifierView notifierView);
        [Export("willHideNotifierView:")]
        void WillHide(FDStatusBarNotifierView notifierView);
        [Export("didHideNotifierView:")]
        void DidHide(FDStatusBarNotifierView notifierView);
        [Export("notifierViewTapped:")]
        void Tapped(FDStatusBarNotifierView notifierView);
    }
}

