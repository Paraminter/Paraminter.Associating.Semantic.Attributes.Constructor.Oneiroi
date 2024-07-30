﻿namespace Paraminter.Semantic.Attributes.Constructor.Oneiroi.Common;

using Paraminter.Queries.Invalidation.Commands;

internal sealed class InvalidateQueryResponseCommand
    : IInvalidateQueryResponseCommand
{
    public static IInvalidateQueryResponseCommand Instance { get; } = new InvalidateQueryResponseCommand();

    private InvalidateQueryResponseCommand() { }
}
