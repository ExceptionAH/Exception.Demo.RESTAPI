using Exception.Demo.RESTAPI.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Demo.RESTAPI.Services.Contracts
{
    public interface IUserService
    {
        Task<string> CreateAsync(User user);

        Task<bool> UpdateAsync(User user);

        Task<bool> DeleteAsync(string id);

        Task<User> GetAsync(string id);
    }
}
