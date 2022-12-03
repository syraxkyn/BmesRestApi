﻿using BmesRestApi.Models.Shared;
using Microsoft.AspNetCore.Identity;

namespace BmesRestApi.Services
{
    public interface IAuthRepository
    {
        Task<IdentityResult> RegisterAsync(User user, string password, CancellationToken cancellationToken = default);
        Task<bool> LogInAsync(string email, string password, CancellationToken cancellationToken = default);
        Task<User> FindAsync(string request, CancellationToken cancellationToken);
        Task<IList<string>> FindUserRolesAsync(string email, CancellationToken cancellationToken);
    }
}
