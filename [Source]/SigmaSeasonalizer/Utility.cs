﻿using System;
using UnityEngine;


namespace SigmaSeasonalizerPlugin
{
    internal static class Utility
    {
        internal static object Lerp(object a, object b, double t)
        {
            if (a.GetType() == typeof(double))
            {
                return Lerp((double)a, (double)b, t);
            }
            if (a.GetType() == typeof(float))
            {
                return Lerp((float)a, (float)b, t);
            }
            if (a.GetType() == typeof(Color))
            {
                return Lerp((Color)a, (Color)b, t);
            }

            return null;
        }

        internal static double Lerp(double a, double b, double t)
        {
            return a * (1 - t) + b * t;
        }

        internal static float Lerp(float a, float b, double t)
        {
            return (float)(a * (1 - t) + b * t);
        }

        internal static Color Lerp(Color a, Color b, double t)
        {
            Color c = new Color
            (
                (float)Math.Pow(Lerp(Math.Pow(a.r, 2), Math.Pow(b.r, 2), t), 0.5f),
                (float)Math.Pow(Lerp(Math.Pow(a.g, 2), Math.Pow(b.g, 2), t), 0.5f),
                (float)Math.Pow(Lerp(Math.Pow(a.b, 2), Math.Pow(b.b, 2), t), 0.5f),
                Lerp(a.a, b.a, t)
            );

            return c;
        }
    }
}