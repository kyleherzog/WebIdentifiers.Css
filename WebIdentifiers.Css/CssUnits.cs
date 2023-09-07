namespace WebIdentifiers.Css;

public static class CssUnits
{
    /// <summary>
    /// Gets the specified value formatted in <c>cm</c> units, which specifies the number of centimeters.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Centimeters(double value) => Cm(value);

    /// <summary>
    /// Gets the specified value formatted in <c>ch</c> units, which are relative to the width of the '0' (zero) units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Ch(double value) => FormatValue(value, "ch");

    /// <summary>
    /// Gets the specified value formatted in <c>cm</c> units, which specifies the number of centimeters.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Cm(double value) => FormatValue(value, "cm");

    /// <summary>
    /// Gets the specified value formatted in <c>em</c> units, which are relative to the font size.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Em(double value) => FormatValue(value, "em");

    /// <summary>
    /// Gets the specified value formatted in <c>ex</c> units, which are relative to the x-height of the current font units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Ex(double value) => FormatValue(value, "ex");

    /// <summary>
    /// Gets the specified value formatted in <c>in</c> units, which specifies the number of inches.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    /// <remarks>One inch is equal to 96 pixels.</remarks>
    public static string In(double value) => FormatValue(value, "in");

    /// <summary>
    /// Gets the specified value formatted in <c>in</c> units, which specifies the number of inches.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Inches(double value) => In(value);

    /// <summary>
    /// Gets the specified value formatted in <c>em</c> units, which are relative to the font size.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string MCharacterWidth(double value) => Em(value);

    /// <summary>
    /// Gets the specified value formatted in <c>mm</c> units, which specifies the number of millimeters.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Millimeters(double value) => Mm(value);

    /// <summary>
    /// Gets the specified value formatted in <c>ms</c> units, which are milliseconds.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Milliseconds(double value) => Ms(value);

    /// <summary>
    /// Gets the specified value formatted in <c>mm</c> units, which specifies the number of millimeters.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Mm(double value) => FormatValue(value, "mm");

    /// <summary>
    /// Gets the specified value formatted in <c>ms</c> units, which are milliseconds.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Ms(double value) => FormatValue(value, "ms");

    /// <summary>
    /// Gets the specified value formatted in <c>pc</c> units, which specifies the number of picas.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    /// <remarks>1 pica = 12 points</remarks>
    public static string Pc(double value) => FormatValue(value, "pc");

    /// <summary>
    /// Gets the specified value formatted in <c>%</c> units, which are relative to the parent element units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Percent(double value) => FormatValue(value, "%");

    /// <summary>
    /// Gets the specified value formatted in <c>pc</c> units, which specifies the number of picas.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Picas(double value) => Pc(value);

    /// <summary>
    /// Gets the specified value formatted in <c>px</c> units, which specifies the number of pixels.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Pixels(double value) => Px(value);

    /// <summary>
    /// Gets the specified value formatted in <c>pt</c> units, which specifies the number of points.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Points(double value) => Pt(value);

    /// <summary>
    /// Gets the specified value formatted in <c>pt</c> units, which specifies the number of points.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    /// <remarks>1 point = 1/72 of an inch</remarks>
    public static string Pt(double value) => FormatValue(value, "pt");

    /// <summary>
    /// Gets the specified value formatted in <c>px</c> units, which specifies the number of pixels.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Px(double value) => FormatValue(value, "px");

    /// <summary>
    /// Gets the specified value formatted in <c>rem</c> units, which are relative to font-size of the root element units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Rem(double value) => FormatValue(value, "rem");

    /// <summary>
    /// Gets the specified value formatted in <c>rem</c> units, which are relative to font-size of the root element units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string RootMCharacterWidth(double value) => Rem(value);

    /// <summary>
    /// Gets the specified value formatted in <c>s</c> units, which are seconds.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string S(double value) => FormatValue(value, "s");

    /// <summary>
    /// Gets the specified value formatted in <c>s</c> units, which are seconds.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Seconds(double value) => S(value);

    /// <summary>
    /// Gets the specified value formatted in <c>vh</c> units, which are relative to 1% of the height of the viewport units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Vh(double value) => FormatValue(value, "vh");

    /// <summary>
    /// Gets the specified value formatted in <c>vh</c> units, which are relative to 1% of the height of the viewport units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string ViewPortHeight(double value) => Vh(value);

    /// <summary>
    /// Gets the specified value formatted in <c>vmax</c> units, which are relative to 1% of the viewport's larger dimension units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string ViewportMaxUnits(double value) => Vmax(value);

    /// <summary>
    /// Gets the specified value formatted in <c>vmin</c> units, which are relative to 1% of the viewport's smaller dimension units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string ViewportMinUnits(double value) => Vmin(value);

    /// <summary>
    /// Gets the specified value formatted in <c>vw</c> units, which are relative to 1% of the width of the viewport units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string ViewportWidth(double value) => Vw(value);

    /// <summary>
    /// Gets the specified value formatted in <c>vmax</c> units, which are relative to 1% of viewport's larger dimension units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Vmax(double value) => FormatValue(value, "vmax");

    /// <summary>
    /// Gets the specified value formatted in <c>vmin</c> units, which are relative to 1% of viewport's smaller dimension units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Vmin(double value) => FormatValue(value, "vmin");

    /// <summary>
    /// Gets the specified value formatted in <c>vw</c> units, which are relative to 1% of the width of the viewport units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string Vw(double value) => FormatValue(value, "vw");

    /// <summary>
    /// Gets the specified value formatted in <c>ex</c> units, which are relative to the x-height of the current font units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string XCharacterHeight(double value) => Ex(value);

    /// <summary>
    /// Gets the specified value formatted in <c>ch</c> units, which are relative to the width of the '0' (zero) units.
    /// </summary>
    /// <param name="value">The number of units.</param>
    /// <returns>The formatted number of units.</returns>
    public static string ZeroCharacterWidth(double value) => Ch(value);

    private static string FormatValue(double value, string unit) => value == 0 ? "0" : $"{value}{unit}";
}