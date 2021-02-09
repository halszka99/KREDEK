using System.Collections.Generic;
using HalszkaCiesielskaZad7.Models;
using HalszkaCiesielskaZad7.Services;
using Microsoft.AspNetCore.Mvc;

namespace HalszkaCiesielskaZad7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        private IShoesService _shoesService;
        /// <summary>
        /// ShoesController constructor 
        /// </summary>
        public ShoesController(IShoesService shoesService)
        {
            _shoesService = shoesService;
        }
        /// <summary>
        /// Returning all shoes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            //creating list of shoes
            List<Shoes> shoesList = _shoesService.GetAllShoes();
            //returning HTTP status code Ok 
            return Ok(shoesList);
        }
        /// <summary>
        /// Adding new shoes
        /// </summary>
        /// <param name="shoes"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Shoes shoes)
        {
            // adding new shoes and assigning new shoes id to variable id
            int id = _shoesService.AddShoes(shoes);
            //returning HTTP status code Ok 
            return Ok(id);
        }
        /// <summary>
        /// Updating slected shoes
        /// </summary>
        /// <param name="shoes"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Shoes shoes, [FromRoute] int id)
        {
            //checking if shoes id is not null and if given id and given id are the same
            if (shoes.Id != null && id != shoes.Id)
                //reuturning HTTP status code  Conflict
                return Conflict("Different id");
            // updating selected shoes
            var isUpdateSuccessful = _shoesService.UpdateShoes(shoes, id);
            //chcecking if updating is succeed
            if (isUpdateSuccessful)
            {
                // if it is returning HTTP code status NoContent
                return NoContent();
            }
            else
            {
                // if it is not returning HTTP code status NotFound
                return NotFound();
            }
        }
        /// <summary>
        /// Deteting selected shoes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            // deleting selected shoes
            var result = _shoesService.DeleteShoes(id);
            //chcecking if deleting is succeed
            if (result)
            {
                // if it is returning HTTP code status NoContent
                return NoContent();
            }
            else
            {
                // if it is not returning HTTP code status NotFound
                return NotFound();
            }

        }
    }
}
