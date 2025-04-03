// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Backend.User.Model;

public sealed class UserModel : BaseEntity<UserId, Guid>
{
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }

    private UserModel(UserId id, string email, string passwordHash)
        : base(id)
    {
        Email = email;
        PasswordHash = passwordHash;
    }

    public static UserModel create(string email, string passwordHash)
    {
        return new UserModel(UserId.New(), email, passwordHash);
    }
}
