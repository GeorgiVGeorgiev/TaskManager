﻿namespace TaskManager.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetFullNameByEmailAsync(string Email);

        Task<bool> IsUserWorkerByIdAsync(string userId);
    }
}
