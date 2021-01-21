using Microsoft.AspNetCore.Mvc;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace Project_Model_DDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IApplicationServiceClient applicationServiceClient;

        public ClientController(IApplicationServiceClient applicationServiceClient)
        {
            this.applicationServiceClient = applicationServiceClient;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceClient.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceClient.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                applicationServiceClient.Add(clientDto);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                applicationServiceClient.Update(clientDto);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                applicationServiceClient.Remove(clientDto);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}