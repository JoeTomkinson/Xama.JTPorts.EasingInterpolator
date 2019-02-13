
# Xamarin EasingInterpolator
[![platform](https://img.shields.io/badge/platform-Xamarin.Android-brightgreen.svg)](https://www.xamarin.com/)
[![API](https://img.shields.io/badge/API-14%2B-orange.svg?style=flat)](https://android-arsenal.com/api?level=14s)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
![Build: Passing](https://img.shields.io/badge/Build-Passing-green.svg)
[![NuGet](https://img.shields.io/nuget/v/Xama.JTPorts.EasingInterpolator.svg?label=NuGet)](https://www.nuget.org/packages/Xama.JTPorts.EasingInterpolator)

### Namespace: Xama.JTPorts.EasingInterpolator

_Xamarin.Android_ Native EasingInterpolator Twenty-eight different easing animation interpolators for Android. ported from [EasingInterpolator](https://github.com/MasayukiSuda/EasingInterpolator) by [Masayuki Suda](https://github.com/MasayukiSuda)

This is a ported build, converted from Java to C# for use with the Xamarin MonoFramework.

# Usage

```cs
ValueAnimator valueAnimator = new ValueAnimator();
valueAnimator.SetInterpolator(new EasingInterpolator(Ease.CUBIC_IN));
valueAnimator.Start();

ObjectAnimator animator = ObjectAnimator.ofFloat(View, "translationY", 0, 300);
animator.SetInterpolator(new EasingInterpolator(Ease.ELASTIC_IN_OUT)));
animator.Start();
```

![Image of easing types](https://github.com/DigitalSa1nt/Xama.JTPorts.EasingInterpolator/blob/master/images/easing.png?raw=true)

# Useful?
<br />
<a href="https://www.buymeacoffee.com/digitalsa1nt" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/purple_img.png" alt="Buy Me A Coffee" style="height: auto !important;width: auto !important;" ></a>

 _You know, only if you want to_
