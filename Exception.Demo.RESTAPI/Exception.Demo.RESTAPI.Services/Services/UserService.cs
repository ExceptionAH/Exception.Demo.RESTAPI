using AutoMapper;
using Exception.Demo.RESTAPI.API.Common.Settings;
using Exception.Demo.RESTAPI.Services.Contracts;
using Exception.Demo.RESTAPI.Services.Model;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Exception.Demo.RESTAPI.Services
{
    public class UserService : IUserService
    {
        private string _connectionString = string.Empty;
        private readonly IMapper _mapper;

        public UserService(IOptions<AppSettings> settings, IMapper mapper)
        {
            _connectionString = settings?.Value?.ConnectionString;
            _mapper = mapper;
        }

        public Task<string> CreateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
