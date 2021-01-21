using Microsoft.AspNetCore.Mvc;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace Project_Model_DDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IApplicationServiceProduct applicationServiceProduct;

        public ProductController(IApplicationServiceProduct applicationServiceProduct)
        {
            this.applicationServiceProduct = applicationServiceProduct;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceProduct.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceProduct.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProductDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                applicationServiceProduct.Add(produtoDto);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProductDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                applicationServiceProduct.Update(produtoDto);
                return Ok("O produto foi atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                applicationServiceProduct.Remove(produtoDto);
                return Ok("O produto foi removido com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}