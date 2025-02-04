﻿// "Therefore those skilled at the unorthodox
// are infinite as heaven and earth,
// inexhaustible as the great rivers.
// When they come to an end,
// they begin again,
// like the days and months;
// they die and are reborn,
// like the four seasons."
//
// - Sun Tsu,
// "The Art of War"

using System.Drawing;
using TheDepartmentOfCode.HtmlRenderer.Adapters;

namespace TheDepartmentOfCode.HtmlRenderer.WinForms.Adapters;

/// <summary>
/// Adapter for WinForms Font family object for core.
/// </summary>
internal sealed class FontFamilyAdapter : RFontFamily
{
    /// <summary>
    /// the underline win-forms font.
    /// </summary>
    private readonly FontFamily _fontFamily;

    /// <summary>
    /// Init.
    /// </summary>
    public FontFamilyAdapter(FontFamily fontFamily)
    {
        _fontFamily = fontFamily;
    }

    /// <summary>
    /// the underline win-forms font family.
    /// </summary>
    public FontFamily FontFamily
    {
        get { return _fontFamily; }
    }

    public override string Name
    {
        get { return _fontFamily.Name; }
    }
}