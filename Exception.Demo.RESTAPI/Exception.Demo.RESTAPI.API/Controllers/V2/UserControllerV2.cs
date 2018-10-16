﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exception.Demo.RESTAPI.API.DataContracts.Requests;
using Exception.Demo.RESTAPI.API.DataContracts;
using Exception.Demo.RESTAPI.Services;
using AutoMapper;
using S = Exception.Demo.RESTAPI.Services.Model;
using Exception.Demo.RESTAPI.Services.Contracts;

namespace Exception.Demo.RESTAPI.API.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/users")]
    public class UserControllerV2 : Controller
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;

        public UserControllerV2(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        #region GET
        [HttpGet("{id}")]
        public async Task<User> Get(string id)
        {
            var data = await _service.GetAsync(id);

            if (data != null)
                return _mapper.Map<User>(data);
            else
                return null;
        }
        #endregion

        #region POST
        [HttpPost]
        public async Task<User> CreateUser([FromBody]UserCreationRequest value)
        {

            //TODO: include exception management policy according to technical specifications
            if (value == null)
                throw new ArgumentNullException("value");


            var data = await _service.CreateAsync(Mapper.Map<S.User>(value));

            if (data != null)
                return _mapper.Map<User>(data);
            else
                return null;

        }
        #endregion

        #region PUT
        [HttpPut()]
        public async Task<bool> UpdateUser(User parameter)
        {
            if (parameter == null)
                throw new ArgumentNullException("parameter");

            return await _service.UpdateAsync(Mapper.Map<S.User>(parameter));
        }
        #endregion

        #region DELETE
        [HttpDelete("{id}")]
        public async Task<bool> DeleteDevice(string id)
        {
            return await _service.DeleteAsync(id);
        }
        #endregion
    }
}
