using Microsoft.AspNetCore.Mvc;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Project_Model_DDD.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IApplicationServiceProduct applicationServiceProduct;

        public ProductController(IApplicationServiceProduct applicationServiceProduct)
        {
            this.applicationServiceProduct = applicationServiceProduct;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>return status ok</returns>
        [SwaggerResponse(statusCode: 200, description: "Action successful")]
        [SwaggerResponse(statusCode: 401, description: "Not authorized")]
        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceProduct.GetAll());
        }

        /// <summary>
        /// Get a product by id
        /// </summary>
        /// <returns>Returns status ok</returns>
        [SwaggerResponse(statusCode: 201, description: "Registered successfully")]
        [SwaggerResponse(statusCode: 401, description: "Not authorized")]
        [HttpGet]
        [Route("GetById")]
        public ActionResult<string> GetById(int id)
        {
            return Ok(applicationServiceProduct.GetById(id));
        }

        /// <summary>
        /// Create new product
        /// </summary>
        /// <returns>return status ok</returns>
        [SwaggerResponse(statusCode: 200, description: "Action successful")]
        [SwaggerResponse(statusCode: 401, description: "Not authorized")]
        [HttpPost]
        [Route("")]
        public ActionResult Post([FromBody] ProductDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                applicationServiceProduct.Add(produtoDto);
                return Created("", applicationServiceProduct);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update a products
        /// </summary>
        /// <returns>return status ok</returns>
        [SwaggerResponse(statusCode: 200, description: "Action successful")]
        [SwaggerResponse(statusCode: 401, description: "Not authorized")]
        [HttpPut]
        [Route("")]
        public ActionResult Put([FromBody] ProductDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                applicationServiceProduct.Update(produtoDto);
                return Ok("");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Delete a product
        /// </summary>
        /// <returns>return status ok</returns>
        [SwaggerResponse(statusCode: 200, description: "Action successful")]
        [SwaggerResponse(statusCode: 401, description: "Not authorized")]
        [HttpDelete]
        [Route("")]
        public ActionResult Delete([FromBody] ProductDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                applicationServiceProduct.Remove(produtoDto);
                return Ok("");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}