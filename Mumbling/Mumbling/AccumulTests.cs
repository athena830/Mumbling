using System;
using NUnit.Framework;

/// <summary>
/// Summary description for AccumulTests
/// </summary>
[TestFixture]
public class AccumulTests
{
    private static void testing(string actual, string expected)
    {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1()
    {
        testing(Accumul.Accum("A"), "A");
        testing(Accumul.Accum("a"), "A");
        testing(Accumul.Accum("ab"), "A-Bb");
        testing(Accumul.Accum("AB"), "A-Bb");
        testing(Accumul.Accum("ABC"), "A-Bb-Ccc");
    }

    [Test]
    public void Empty()
    {
        testing(Accumul.Accum(""), "");
    }
}