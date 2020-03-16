using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebApiAndODataIssue.Api.WebApi
{
    [ApiController]
    [Route("_api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 2).Select(index => new User
            {
                UserId = Guid.NewGuid(),
                Email = $"{index}@api.poc.com",
                Name = $"WebApi {index}",
            })
            .ToArray();
        }
    }
}