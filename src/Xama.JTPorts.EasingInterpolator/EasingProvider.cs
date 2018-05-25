using System;

namespace Xama.JTPorts.EasingInterpolator
{
    public class EasingProvider
    {
        public static float Get(Ease ease, float elapsedTimeRate)
        {
            switch (ease)
            {
                case Ease.Linear:
                    return elapsedTimeRate;
                case Ease.QuadIn:
                    return getPowIn(elapsedTimeRate, 2);
                case Ease.QuadOut:
                    return GetPowOut(elapsedTimeRate, 2);
                case Ease.QuadInOut:
                    return GetPowInOut(elapsedTimeRate, 2);
                case Ease.CubicIn:
                    return getPowIn(elapsedTimeRate, 3);
                case Ease.CubicOut:
                    return GetPowOut(elapsedTimeRate, 3);
                case Ease.CubicInOut:
                    return GetPowInOut(elapsedTimeRate, 3);
                case Ease.QuartIn:
                    return getPowIn(elapsedTimeRate, 4);
                case Ease.QuartOut:
                    return GetPowOut(elapsedTimeRate, 4);
                case Ease.QuartInOut:
                    return GetPowInOut(elapsedTimeRate, 4);
                case Ease.QuintIn:
                    return getPowIn(elapsedTimeRate, 5);
                case Ease.QuintOut:
                    return GetPowOut(elapsedTimeRate, 5);
                case Ease.QuintInOut:
                    return GetPowInOut(elapsedTimeRate, 5);
                case Ease.SineIn:
                    return (float)(1f - Math.Cos(elapsedTimeRate * Math.PI / 2f));
                case Ease.SineOut:
                    return (float)Math.Sin(elapsedTimeRate * Math.PI / 2f);
                case Ease.SineInOut:
                    return (float)(-0.5f * (Math.Cos(Math.PI * elapsedTimeRate) - 1f));
                case Ease.BackIn:
                    return (float)(elapsedTimeRate * elapsedTimeRate * ((1.7 + 1f) * elapsedTimeRate - 1.7));
                case Ease.BackOut:
                    return (float)(--elapsedTimeRate * elapsedTimeRate * ((1.7 + 1f) * elapsedTimeRate + 1.7) + 1f);
                case Ease.BackInOut:
                    return GetBackInOut(elapsedTimeRate, 1.7f);
                case Ease.CircIn:
                    return (float)-(Math.Sqrt(1f - elapsedTimeRate * elapsedTimeRate) - 1);
                case Ease.CircOut:
                    return (float)Math.Sqrt(1f - (--elapsedTimeRate) * elapsedTimeRate);
                case Ease.CircInOut:
                    if ((elapsedTimeRate *= 2f) < 1f)
                    {
                        return (float)(-0.5f * (Math.Sqrt(1f - elapsedTimeRate * elapsedTimeRate) - 1f));
                    }
                    return (float)(0.5f * (Math.Sqrt(1f - (elapsedTimeRate -= 2f) * elapsedTimeRate) + 1f));
                case Ease.BounceIn:
                    return GetBounceIn(elapsedTimeRate);
                case Ease.BounceOut:
                    return GetBounceOut(elapsedTimeRate);
                case Ease.BounceInOut:
                    if (elapsedTimeRate < 0.5f)
                    {
                        return GetBounceIn(elapsedTimeRate * 2f) * 0.5f;
                    }
                    return GetBounceOut(elapsedTimeRate * 2f - 1f) * 0.5f + 0.5f;
                case Ease.ElasticIn:
                    return GetElasticIn(elapsedTimeRate, 1, 0.3);

                case Ease.ElasticOut:
                    return GetElasticOut(elapsedTimeRate, 1, 0.3);

                case Ease.ElasticInOut:
                    return GetElasticInOut(elapsedTimeRate, 1, 0.45);

                default:
                    return elapsedTimeRate;
            }
        }

        /// <summary>
        /// elapsedTimeRate Elapsed time / Total time, pow The exponent to use (ex. 3 would return a cubic ease) returns eased value
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <param name="pow"></param>
        /// <returns></returns>
        private static float getPowIn(float elapsedTimeRate, double pow)
        {
            return (float)Math.Pow(elapsedTimeRate, pow);
        }

        /// <summary>
        /// Returns eased value.
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <param name="pow"></param>
        /// <returns></returns>
        private static float GetPowOut(float elapsedTimeRate, double pow)
        {
            return (float)((float)1 - Math.Pow(1 - elapsedTimeRate, pow));
        }

        /// <summary>
        /// Gets eased value
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <param name="pow"></param>
        /// <returns></returns>
        private static float GetPowInOut(float elapsedTimeRate, double pow)
        {
            if ((elapsedTimeRate *= 2) < 1)
            {
                return (float)(0.5 * Math.Pow(elapsedTimeRate, pow));
            }

            return (float)(1 - 0.5 * Math.Abs(Math.Pow(2 - elapsedTimeRate, pow)));
        }

        /// <summary>
        /// Get eased value from Elapsed time / Total time and the amount The strength of the ease.
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        private static float GetBackInOut(float elapsedTimeRate, double amount)
        {
            amount *= 1.525;
            if ((elapsedTimeRate *= 2) < 1)
            {
                return (float)(0.5 * (elapsedTimeRate * elapsedTimeRate * ((amount + 1) * elapsedTimeRate - amount)));
            }
            return (float)(0.5 * ((elapsedTimeRate -= 2) * elapsedTimeRate * ((amount + 1) * elapsedTimeRate + amount) + 2));
        }

        /// <summary>
        /// Bounce in ease value from Elapsed time / Total time
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <returns></returns>
        private static float GetBounceIn(float elapsedTimeRate)
        {
            return 1f - GetBounceOut(1f - elapsedTimeRate);
        }

        /// <summary>
        /// Bounce out ease value.
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <returns></returns>
        private static float GetBounceOut(double elapsedTimeRate)
        {
            if (elapsedTimeRate < 1 / 2.75)
            {
                return (float)(7.5625 * elapsedTimeRate * elapsedTimeRate);
            }
            else if (elapsedTimeRate < 2 / 2.75)
            {
                return (float)(7.5625 * (elapsedTimeRate -= 1.5 / 2.75) * elapsedTimeRate + 0.75);
            }
            else if (elapsedTimeRate < 2.5 / 2.75)
            {
                return (float)(7.5625 * (elapsedTimeRate -= 2.25 / 2.75) * elapsedTimeRate + 0.9375);
            }
            else
            {
                return (float)(7.5625 * (elapsedTimeRate -= 2.625 / 2.75) * elapsedTimeRate + 0.984375);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <param name="amplitude"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        private static float GetElasticIn(float elapsedTimeRate, double amplitude, double period)
        {
            if (elapsedTimeRate == 0 || elapsedTimeRate == 1) return elapsedTimeRate;
            double pi2 = Math.PI * 2;
            double s = period / pi2 * Math.Asin(1 / amplitude);
            return (float)-(amplitude * Math.Pow(2f, 10f * (elapsedTimeRate -= 1f)) * Math.Sin((elapsedTimeRate - s) * pi2 / period));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <param name="amplitude"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        private static float GetElasticOut(float elapsedTimeRate, double amplitude, double period)
        {
            if (elapsedTimeRate == 0 || elapsedTimeRate == 1) return elapsedTimeRate;

            double pi2 = Math.PI * 2;
            double s = period / pi2 * Math.Asin(1 / amplitude);
            return (float)(amplitude * Math.Pow(2, -10 * elapsedTimeRate) * Math.Sin((elapsedTimeRate - s) * pi2 / period) + 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elapsedTimeRate"></param>
        /// <param name="amplitude"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        private static float GetElasticInOut(float elapsedTimeRate, double amplitude, double period)
        {
            double pi2 = Math.PI * 2;

            double s = period / pi2 * Math.Asin(1 / amplitude);
            if ((elapsedTimeRate *= 2) < 1)
            {
                return (float)(-0.5f * (amplitude * Math.Pow(2, 10 * (elapsedTimeRate -= 1f)) * Math.Sin((elapsedTimeRate - s) * pi2 / period)));
            }
            return (float)(amplitude * Math.Pow(2, -10 * (elapsedTimeRate -= 1)) * Math.Sin((elapsedTimeRate - s) * pi2 / period) * 0.5 + 1);

        }
    }
}