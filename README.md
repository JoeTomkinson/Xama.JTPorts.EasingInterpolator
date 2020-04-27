
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

# Support 💎

If you want to support the work that I do and you find any of these libraries useful? Consider supporting it by joining [**stargazers**](https://github.com/DigitalSa1nt/Xama.JTPorts.EasingInterpolator/stargazers) for this repository. :telescope: :stars:

<br/>

or alternatively if you want to you can also buy me a coffee.

<a href="https://www.buymeacoffee.com/JTT" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-red.png" alt="Buy Me A Coffee" tyle="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>
-----
_You know, only if you want to._
