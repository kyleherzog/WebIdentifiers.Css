using System;
using System.Collections.Generic;
using System.Text;

namespace WebIdentifiers.Css.Generating.CodeWriting;
public class XmlDocsWriter
{
    internal XmlDocsWriter(ClassWriter classWriter)
    {
        ClassWriter = classWriter;
    }

    public ClassWriter ClassWriter { get; }

    public void AddSummary(string summary)
    {
        ClassWriter.AddLine($"/// <summary>");
        ClassWriter.AddLine($"/// {summary}");
        ClassWriter.AddLine($"/// </summary>");
    }

    public void AddParam(string name, string description)
    {
        ClassWriter.AddLine($"/// <param name=\"{name}\">{description}</param>");
    }

    public void AddReturns(string description)
    {
        ClassWriter.AddLine($"/// <returns>{description}</returns>");
    }
}
