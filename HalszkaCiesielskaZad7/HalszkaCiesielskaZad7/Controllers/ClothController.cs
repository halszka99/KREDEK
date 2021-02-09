using System.Collections.Generic;
using HalszkaCiesielskaZad7.Models;
using HalszkaCiesielskaZad7.Services;
using Microsoft.AspNetCore.Mvc;

namespace HalszkaCiesielskaZad7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothController : ControllerBase
    {
        private IClothService _clothService;
        /// <summary>
        /// ClothController constructor 
        /// </summary>
        public ClothController(IClothService clothService)
        {
            _clothService = clothService;
        }
        /// <summary>
        /// Returning all clothes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            //creating list of clothes
            List<Cloth> clothesList = _clothService.GetAllClothes();
            //returning HTTP status code Ok 
            return Ok(clothesList);
        }
        /// <summary>
        /// Adding new cloth
        /// </summary>
        /// <param name="cloth"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Cloth cloth)
        {
            // adding new cloth and assigning new cloth id to variable id
            int id = _clothService.AddCloth(cloth);
            //returning HTTP status code Ok 
            return Ok(id);
        }
        /// <summary>
        /// Updating slected cloth
        /// </summary>
        /// <param name="cloth"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Cloth cloth, [FromRoute] int id)
        {
            //checking if cloth id is not null and if given id and given id are the same
            if (cloth.Id != null && id != cloth.Id)
                //reuturning HTTP status code  Conflict
                return Conflict("Different id");
            // updating selected cloth
            var isUpdateSuccessful = _clothService.UpdateCloth(cloth, id);
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
        /// Deteting selected cloth
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            // deleting selected cloth
            var isDeletedSuccessful = _clothService.DeleteCloth(id);
            //chcecking if deleting is succeed
            if (isDeletedSuccessful)
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
