using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Attributes;

namespace WebApiAndODataIssue.Api.WebApi
{
    [Route("_api/users")]
    [NonODataController]
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