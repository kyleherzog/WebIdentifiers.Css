using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebIdentifiers.Css.UnitTests.CssUnitsTests;

[TestClass]
public class PxShould
{
    [DataTestMethod]
    [DataRow(0, "0")]
    [DataRow(1, "1px")]
    [DataRow(1.5, "1.5px")]
    [DataRow(-1, "-1px")]
    [DataRow(1000, "1000px")]
    public void ReturnCorrectValue(double value, string expected)
    {
        var actual = CssUnits.Px(value);

        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow(0, "0")]
    [DataRow(1, "1px")]
    [DataRow(-1, "-1px")]
    [DataRow(1000, "1000px")]
    public void ReturnCorrectValueGiveIntParameter(int value, string expected)
    {
        var actual = CssUnits.Px(value);

        Assert.AreEqual(expected, actual);
    }
}
