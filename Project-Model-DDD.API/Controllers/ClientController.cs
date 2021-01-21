using Microsoft.AspNetCore.Mvc;
using Project_Model_DDD.API.Filters;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Project_Model_DDD.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IApplicationServiceClient applicationServiceClient;

        public ClientController(IApplicationServiceClient applicationServiceClient)
        {
            this.applicationServiceClient = applicationServiceClient;
        }

        /// <summary>
        /// Get all clients
        /// </summary>
        /// <returns>return status ok</returns>
        [SwaggerResponse(statusCode: 200, description: "Action successful")]
        [SwaggerResponse(statusCode: 500, description: "Internal error", Type = typeof(GenericErrorViewModel))]
        [CustomModelStateValidation]
        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceClient.GetAll());
        }

        /// <summary>
        /// Get a client by id
        /// </summary>
        /// <returns>Returns status ok</returns>
        [SwaggerResponse(statusCode: 201, description: "Action successful")]
        [SwaggerResponse(statusCode: 500, description: "Internal error", Type = typeof(GenericErrorViewModel))]
        [CustomModelStateValidation]
        [HttpGet]
        [Route("GetById")]
        public ActionResult<string> GetById(int id)
        {
            return Ok(applicationServiceClient.GetById(id));
        }

        /// <summary>
        /// Create new client
        /// </summary>
        /// <returns>return status ok</returns>
        [SwaggerResponse(statusCode: 201, description: "Registered successfully")]
        [SwaggerResponse(statusCode: 400, description: "Fields required", Type = typeof(CheckFieldsViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Internal error", Type = typeof(GenericErrorViewModel))]
        [CustomModelStateValidation]
        [HttpPost]
        [Route("")]
        public ActionResult Post([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                applicationServiceClient.Add(clientDto);
                return Created("", applicationServiceClient.GetAll());
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update a client
        /// </summary>
        /// <returns>return status ok</returns>
        [SwaggerResponse(statusCode: 200, description: "Action successful")]
        [SwaggerResponse(statusCode: 400, description: "Fields required", Type = typeof(CheckFieldsViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Internal error", Type = typeof(GenericErrorViewModel))]
        [CustomModelStateValidation]
        [HttpPut]
        [Route("")]
        public ActionResult Put([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                applicationServiceClient.Update(clientDto);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Delete a client
        /// </summary>
        /// <returns>return status ok</returns>
        [SwaggerResponse(statusCode: 200, description: "Action successful")]
        [SwaggerResponse(statusCode: 500, description: "Internal error", Type = typeof(GenericErrorViewModel))]
        [CustomModelStateValidation]
        [HttpDelete]
        [Route("")]
        public ActionResult Delete([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                applicationServiceClient.Remove(clientDto);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}