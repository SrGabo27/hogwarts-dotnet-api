using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using hogwartsApi.Domain.Models;
using hogwartsApi.Domain.Services;
using hogwartsApi.Resources;
using hogwartsApi.Extensions;

namespace hogwartsApi.Controllers
{
    [Produces("application/json")]
    [Route("/api/application")]
    public class ApplicationController : Controller
    {
        private readonly IApplicationService _applicationService;
        private readonly IMapper _mapper;

        public ApplicationController(IApplicationService applicationService, IMapper mapper)
        {
            _applicationService = applicationService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all the applications.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<ApplicationResource>> GetAllAsync()
        {
            var applications = await _applicationService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Application>, IEnumerable<ApplicationResource>>(applications);

            return resources;
        }

        /// <summary>
        /// Create a new student application.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveApplicationResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            if (resource.House != EHouse.Gryffindor && resource.House != EHouse.Ravenclaw && resource.House != EHouse.Slytherin && resource.House != EHouse.Hufflepuff)
                return BadRequest("House must be a valid house");

            var application = _mapper.Map<SaveApplicationResource, Application>(resource);
            var result = await _applicationService.SaveAsync(application);

            if (!result.Success)
                return BadRequest(result.Message);

            var applicationResource = _mapper.Map<Application, ApplicationResource>(result.Application);

            return Ok(applicationResource);
        }


        /// <summary>
        /// Update a new student application.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveApplicationResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var application = _mapper.Map<SaveApplicationResource, Application>(resource);
            var result = await _applicationService.UpdateAsync(id, application);

            if (!result.Success)
                return BadRequest(result.Message);

            var applicationResource = _mapper.Map<Application, ApplicationResource>(result.Application);
            return Ok(applicationResource);
        }

        /// <summary>
        /// Delete a new student application.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _applicationService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var applicationResource = _mapper.Map<Application, ApplicationResource>(result.Application);
            return Ok(applicationResource);
        }
    }
}
