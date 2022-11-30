﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComparingObjectsUnitTest.Base;

public enum Trait
{
    /// <summary>
    /// Place holder 
    /// </summary>
    PlaceHolder,
    ReadPerson,
    Distinct,
    GenericWrappers,
    Grouping,
    SequenceEqual,
    ObjectEqualsOverride,
    ReadFile
}
/// <summary>
/// Declarative class for using Trait enum about for traits on test method.
/// </summary>
public class TestTraitsAttribute : TestCategoryBaseAttribute
{
    private readonly Trait[] _traits;

    public TestTraitsAttribute(params Trait[] traits)
    {
        _traits = traits;
    }

    public override IList<string> TestCategories => _traits.Select(trait => Enum.GetName(typeof(Trait), trait)).ToList();
}