using ApiHospitalesAzure.Models;
using ApiHospitalesAzure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHospitalesAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalesController : ControllerBase
    {
        private RepositoryHospital repo;

        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Hospital>> Get()
        {
            return this.repo.GetHospitales();
        }

        [HttpGet("{id}")]
        public ActionResult<Hospital> Get(int id)
        {
            return this.repo.FindHospital(id);
        }
    }
}
