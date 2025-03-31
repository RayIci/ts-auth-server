// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Backend.Core.Entities;

public abstract class AbstractId<TId>
    where TId : IEquatable<TId>
{
    public TId Value { get; protected set; }

    protected AbstractId(TId value) => Value = value;

    /// <summary>
    /// Check if two IDs are equals.
    /// Two IDs are equals if their values are the same.
    /// </summary>
    /// <param name="obj">The IDs to equals to.</param>
    /// <returns>True if the value of the ids is the same, false otherwise</returns>
    public override bool Equals(object? obj)
    {
        // Cast the obj as AbstractId with generic equal
        // generic TId and check if it can be converted.
        if (obj is not AbstractId<TId> objId)
        {
            return false;
        }

        // Two AbstractId are equals if their value is the same.
        return objId.Value.Equals(Value);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public override string? ToString() => Value.ToString();
}
