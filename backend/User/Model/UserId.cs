// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Backend.User.Model;

public class UserId : AbstractId<Guid>
{
    private UserId(Guid value) : base(value) { }
    public static UserId New => new(Guid.NewGuid());
}
