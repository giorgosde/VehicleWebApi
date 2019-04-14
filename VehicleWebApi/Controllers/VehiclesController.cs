using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleWebApi.DAL.Context;
using VehicleWebApi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using VehicleWebApi.DAL.Repositories;

namespace VehicleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : Controller
    {
        private readonly IModelRepository _modelRepository;

        public VehiclesController(IModelRepository modelRepository)
        {
            this._modelRepository = modelRepository;
        }

        /// <summary>
        /// Returns a list of Models
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Model>>> Get()
        {
            return Ok(await this._modelRepository.GetAll().ToListAsync());
        }

        /// <summary>
        /// Returns Model record for given Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Model>> Get(int id)
        {
            var model = await this._modelRepository.GetById(id);
            if (model == null)
                return BadRequest("Record wasn't found");

            return Ok(model);
        }

        /// <summary>
        /// Saves the posted Model
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Model>> Add(Model model)
        {
            return Ok(await this._modelRepository.Create(model));
        }

        /// <summary>
        /// Updated the passed Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody]Model model)
        {
            if (id != model.Id)
                return BadRequest("Ids do not match");

            return Ok(await this._modelRepository.Update(id, model));
        }

        
        /// <summary>
        /// Deleted the Model with the requested Id value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _modelRepository.GetById(id);

            if (model == null)
                return BadRequest("Record wasn't found");

            return Ok(await this._modelRepository.Delete(id));
        }

    }
}
