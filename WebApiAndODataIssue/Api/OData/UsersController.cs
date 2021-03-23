using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace WebApiAndODataIssue.Api.OData
{
    public class UsersController : ODataController
    {
        [HttpGet]
        [EnableQuery]
        public IEnumerable<User> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new User
            {
                UserId = Guid.NewGuid(),
                Email = $"{index}@odata.poc.com",
                Name = $"OData {index}",
            })
            .ToArray();
        }
    }
}
