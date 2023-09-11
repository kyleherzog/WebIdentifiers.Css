using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebIdentifiers.Css.Generating.Models;

[DataContract]
public class CssReference
{
    [DataMember(Name = "properties")]
    public IList<CssProperty> Properties { get; set; }
}
