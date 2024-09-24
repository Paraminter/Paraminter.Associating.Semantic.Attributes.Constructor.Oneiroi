﻿namespace Paraminter.Associating.Semantic.Attributes.Constructor.Oneiroi.Errors;

using Paraminter.Associating.Semantic.Attributes.Constructor.Oneiroi.Errors.Commands;
using Paraminter.Cqs.Handlers;

using Xunit;

public sealed class DifferentNumberOfArgumentsAndParameters
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsHandler()
    {
        var result = Target();

        Assert.Same(Fixture.DifferentNumberOfArgumentsAndParametersMock.Object, result);
    }

    private ICommandHandler<IHandleDifferentNumberOfArgumentsAndParametersCommand> Target() => Fixture.Sut.DifferentNumberOfArgumentsAndParameters;
}
