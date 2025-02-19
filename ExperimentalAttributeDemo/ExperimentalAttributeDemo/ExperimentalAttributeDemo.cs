using System;
using System.Diagnostics.CodeAnalysis;

public class ExperimentalAttributeDemo
{
    [Experimental("ExperimentalFeature")]
    static void ExperimentalMethod()
    {
        Console.WriteLine("이것은 실험적인 기능입니다.");
    }

    static void Main()
    {
#pragma warning disable ExperimentalFeature
        ExperimentalMethod();
#pragma warning restore ExperimentalFeature
    }
}
