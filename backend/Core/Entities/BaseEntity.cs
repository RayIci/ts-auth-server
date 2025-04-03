// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Backend.Core.Entities;

public abstract class BaseEntity<TId, TIdValue>
    where TId : AbstractId<TIdValue>
    where TIdValue : IEquatable<TIdValue>
{
    public TId Id { get; protected set; }

    protected BaseEntity(TId id) => Id = id;

    /// <summary>
    /// Check if two entities are equals.
    /// Two entities are equals if their ids are the same.
    /// </summary>
    /// <param name="obj">The entity to equals to.</param>
    /// <returns>True if the ids are the same, false otherwise</returns>
    public override bool Equals(object? obj)
    {
        // Two entities are the same if they have the same id
        if (obj is not BaseEntity<TId, TIdValue> objEntity)
        {
            return false;
        }

        return objEntity.Id.Equals(Id);
    }

    public override int GetHashCode() => Id.GetHashCode();

    public override string? ToString() => base.ToString();
}
