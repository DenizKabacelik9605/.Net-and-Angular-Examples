using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CargoManagementSystemV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoesController : ControllerBase
    {


        private readonly CargoContext _cargoContext;

        public CargoesController(CargoContext cargoContext) {


            _cargoContext = cargoContext;

        }


        [HttpGet]

        public async Task<ActionResult<IEnumerable<Cargo>>> GetCargo()
        {

            return await _cargoContext.Cargos.ToListAsync();

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Cargo>> GetCargoBYId(int id)
        {

            return await _cargoContext.Cargos.FindAsync(id);

        }

        //[HttpPost]
        //public async Task<IActionResult> PostAsync(Cargo cargo)
        //{
        //    _cargoContext.Cargos.Add(cargo);
        //     await _cargoContext.SaveChangesAsync();

        //    return Created($"{cargo.Id}", cargo);
            
        //}
    }
}
