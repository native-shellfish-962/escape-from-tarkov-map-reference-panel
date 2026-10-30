// Build: 7e05e5faf849489edc9cd73e52443633
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
