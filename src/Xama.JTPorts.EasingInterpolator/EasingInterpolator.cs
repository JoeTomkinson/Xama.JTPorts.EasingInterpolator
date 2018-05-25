using Android.Animation;

namespace Xama.JTPorts.EasingInterpolator
{
    /// <summary>
    /// The Easing class provides a collection of ease functions. It does not use the standard 4 param
    /// ease signature.Instead it uses a single param which indicates the current linear ratio(0 to 1) of the tween.
    /// </summary>
    public class EasingInterpolator : Java.Lang.Object, ITimeInterpolator
    {
        private Ease ease;

        public EasingInterpolator(Ease ease)
        {
            this.ease = ease;
        }

        public Ease getEase()
        {
            return ease;
        }

        public float GetInterpolation(float input)
        {
            return EasingProvider.Get(this.ease, input);
        }
    }
}