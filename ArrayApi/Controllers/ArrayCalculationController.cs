using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArrayApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArrayApi.Controllers
{
    [Route("api/arraycalc")]
    [ApiController]
    public class ArrayCalculationController : ControllerBase
    {
        private readonly IArrayServices _arrayServices;

        public ArrayCalculationController(IArrayServices arrayServices)
        {
            _arrayServices = arrayServices;
        }

        // GET api/reverse
        [HttpGet("reverse")]
        public async Task<ActionResult<IEnumerable<int>>> Reverse([FromQuery] int[] productIds)
        {
            // Reverse the provided numbers of product id 
            var response = await _arrayServices.Reverse(productIds);

            return Ok(response);
        }

        // GET api/deletepart
        [HttpGet("deletepart")]
        public async Task<ActionResult<IEnumerable<int>>> DeleteByPosition([FromQuery] int position, [FromQuery] int[] productIds)
        {
            // Delete an element within the provided numbers based on it's position
            var response = await _arrayServices.DeleteByPosition(position, productIds);
            return Ok(response);
        }
    }
}
