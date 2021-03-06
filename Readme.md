# Material Color Wheel Demo

### Description:
This is a color selection control built for use with the [Material Design in XAML Toolkit.](https://github.com/ButchersBoy/MaterialDesignInXamlToolkit) It is based on Google's CSS customizer for their Material Design Lite framework.

### Screenshots:
![Animated GIF](https://i.imgsafe.org/2c300059ae.gif)
![](https://i.imgsafe.org/2c09b3d3e8.png)  
![](https://i.imgsafe.org/2aff0a3842.png)
![](https://i.imgsafe.org/2c0babc32b.png)

### Installation and Use:
* Install the NuGet package. `Install-Package MaterialDesignAddon`
* Make sure you add the following resources to your App.xaml  
```
<ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml" />
<ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml" />
<ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Blue.xaml" />
<ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Yellow.xaml" />
```
* Add the `xmlns:addon="http://schemas.landmarkdevs.com/xaml"` namespace to the user control.
* Add `<addon:MaterialColorWheel />` where you want to use the control.
* When you click a color the primary color will change. When you click the second color the accent color will change.

### Credits
Thank you to [ButchersBoy](https://github.com/ButchersBoy) for creating the Material Design in XAML Toolkit.  
Thank you to Google for releasing the Material Design standard.  
[Google's CSS Customizer](https://getmdl.io/customize/index.html)