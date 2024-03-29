﻿namespace BluDay.Net.Common.Extensions;

public static class CharExtensions
{
    public static bool IsAlphanumeric(this char source)
    {
        return char.IsLetterOrDigit(source);
    }

    public static bool IsDashOrUnderscore(this char source)
    {
        return source is Constants.DASH_CHAR || source is Constants.UNDERSCORE_CHAR;
    }

    public static bool IsNotEmptyOrWhitespace(this char source)
    {
        return source is not Constants.EMPTY_CHAR && source is not Constants.WHITESPACE_CHAR;
    }
}