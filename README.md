
# Xamarin EasingInterpolator
[![platform](https://img.shields.io/badge/platform-Xamarin.Android-brightgreen.svg)](https://www.xamarin.com/)
[![API](https://img.shields.io/badge/API-14%2B-orange.svg?style=flat)](https://android-arsenal.com/api?level=14s)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
![Build: Passing](https://img.shields.io/badge/Build-Passing-green.svg)
[![NuGet](https://img.shields.io/nuget/v/Xama.JTPorts.EasingInterpolator.svg?label=NuGet)](https://www.nuget.org/packages/Xama.JTPorts.EasingInterpolator)

### Namespace: Xama.JTPorts.EasingInterpolator

_Xamarin.Android_ Native EasingInterpolator Twenty-eight different easing animation interpolators for Android. ported from [EasingInterpolator](https://github.com/MasayukiSuda/EasingInterpolator) by [Masayuki Suda](https://github.com/MasayukiSuda)

This is a ported build, converted from Java to C# for use with the Xamarin MonoFramework.

# Installation
![NugetIcon](https://raw.githubusercontent.com/DigitalSa1nt/Xama.JTPorts.EasingInterpolator/master/images/nugetIcon.png)

Simply install the nuget package within your Xamarin.Android project and use as described below.

Package Install:
> Install-Package Xama.JTPorts.EasingInterpolator -Version 1.0.2

.NET CLI:
>  dotnet add package Xama.JTPorts.EasingInterpolator --version 1.0.2

# Usage

```cs
ValueAnimator valueAnimator = new ValueAnimator();
valueAnimator.SetInterpolator(new EasingInterpolator(Ease.CubicIn));
valueAnimator.Start();

ObjectAnimator objectAnimator = ObjectAnimator.OfFloat(View, "translationY", 0, 300);
objectAnimator.SetInterpolator(new EasingInterpolator(Ease.ElasticInOut)));
objectAnimator.Start();
```

![Image of easing types](https://github.com/DigitalSa1nt/Xama.JTPorts.EasingInterpolator/blob/master/images/easingdiagram.png?raw=true)

# Useful?
<br />
<a href="https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=PFBEH42KW5P84" method="post" target="_top"><img src="https://camo.githubusercontent.com/b8efed595794b7c415163a48f4e4a07771b20abe/68747470733a2f2f7777772e6275796d6561636f666665652e636f6d2f6173736574732f696d672f637573746f6d5f696d616765732f707572706c655f696d672e706e67" alt="Buy Me A Coffee" style="height: auto !important;width: auto !important;" ></a>

 _You know, only if you want to_
