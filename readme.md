Xamarin.iOS binding to https://github.com/frankdilo/FDStatusBarNotifierView

Hot to compile:

1. Build schema "Universal Binary" in the XCode project /NativeLib/FDStatusBarNotifierViewLib
   You'll get a libFDStatusBarNotifierViewLib.a in repository root

2. Open the Xamarin/Visual Studio solution, in the Binding Project add libFDStatusBarNotifierViewLib.a

3. Build the Binding Project

4. In the Sample Project, add the resulting Binding.dll as a reference
   NOT the Binding Project, but the resulting DLL compiled as Release

5. Build Sample and try it out


When using it, remember to target your application to iOS 6.0 and set the flag "Viewcontroller based status bar appearance" to NO in your info.plist

TODO: make it work in a project targeted to iOS 7.0
      find a way to automatize the cumbersome build process
      add some things to the original FDStatusBarNotifierView such as customizable colors and progress indicators (to make it more similar to Windows Phones's SystemTray feature-wise)

