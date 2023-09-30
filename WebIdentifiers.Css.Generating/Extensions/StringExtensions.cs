using System;
using System.Collections.Generic;
using System.Text;

namespace WebIdentifiers.Css.Generating;

internal static class StringExtensions
{
    public static string EscapeXml(this string s)
    {
        string toxml = s;
        if (!string.IsNullOrEmpty(toxml))
        {
            // replace literal values with entities
            toxml = toxml.Replace("&", "&amp;");
            toxml = toxml.Replace("'", "&apos;");
            toxml = toxml.Replace("\"", "&quot;");
            toxml = toxml.Replace(">", "&gt;");
            toxml = toxml.Replace("<", "&lt;");
        }
        return toxml;
    }
}
