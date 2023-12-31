﻿using B221210351.EFContext;
using B221210351.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace B221210351.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliclinicsApiController : ControllerBase
    {
        private readonly HastaneDbContext context;

        public PoliclinicsApiController(HastaneDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public Policlinic Get(int id)
        {
            Policlinic data = context.Policlinics.Find(id);
            return data;
        }

        [HttpGet]
        public List<Policlinic> Get()
        {
            List<Policlinic> data = context.Policlinics.ToList();
            return data;
        }
    }
}
