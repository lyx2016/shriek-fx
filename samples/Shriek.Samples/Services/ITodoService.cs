﻿using Shriek.Samples.Models;
using Shriek.ServiceProxy.Abstractions;
using Shriek.ServiceProxy.Http;
using System.Threading.Tasks;

namespace Shriek.Samples.Services
{
    [Route("api")]
    public interface ITodoService
    {
        [HttpPost("todo")]
        Task<Todo> Create([JsonContent] Todo todo);

        [Route("route/{id:int}")]
        [HttpGet("route2/{id:int}")]
        Task<Todo> Get(int id);

        [HttpGet("{name}")]
        Task<Todo> Get(string name);
    }
}