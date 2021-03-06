﻿using System;
using BirdWatcher.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BirdWatcher.Web.Controllers
{
    [Route("observation")]
    public class ObservationController : Controller
    {


        private readonly Repository _repo;

        public ObservationController(Repository repo)
        {
            _repo = repo;
        }



        [HttpPost("recreate")]
        public IActionResult RecreateDatabase()
        {
            _repo.RecreateDatabase();
            return Ok();
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var v = _repo.GetAll();
            return Ok(v);
        }



       
        [HttpPost]
        public IActionResult Add([FromBody]Observation observation)
        {
          
            _repo.Add(observation);


            return Ok(observation.Id);
        }

    }
}
