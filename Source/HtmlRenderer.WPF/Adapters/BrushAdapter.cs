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

using System.Windows.Media;
using TheDepartmentOfCode.HtmlRenderer.Adapters;

namespace TheDepartmentOfCode.HtmlRenderer.WPF.Adapters;

/// <summary>
/// Adapter for WPF brushes.
/// </summary>
internal sealed class BrushAdapter : RBrush
{
    /// <summary>
    /// The actual WPF brush instance.
    /// </summary>
    private readonly Brush _brush;

    /// <summary>
    /// Init.
    /// </summary>
    public BrushAdapter(Brush brush)
    {
        _brush = brush;
    }

    /// <summary>
    /// The actual WPF brush instance.
    /// </summary>
    public Brush Brush
    {
        get { return _brush; }
    }

    public override void Dispose()
    { }
}