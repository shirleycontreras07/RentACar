using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentCar.Data;
using RentCar.Models.RentCarModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RentCar.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly RentCarDbContext _context;

        public VehiculosController(RentCarDbContext context)
        {
            _context = context;
        }

        // GET: Vehiculos
        public async Task<IActionResult> Index(string Criterio = null)
        {
            var rentCarDbContext = _context.Vehiculos.Include(v => v.Marca).Include(v => v.Modelo).Include(v => v.TipoCombustible).Include(v => v.TipoVehiculo);
            return View(await rentCarDbContext.Where(p => Criterio == null || p.IdVehiculo.ToString().StartsWith(Criterio) ||
                                                                            p.Descripcion.StartsWith(Criterio) || p.NumPlaca.ToString().StartsWith(Criterio) ||
                                                                              p.NumChasis.ToString().StartsWith(Criterio) || p.TipoVehiculo.Descripcion.StartsWith(Criterio) ||
                                                                              p.Marca.Descripcion.StartsWith(Criterio) || p.Marca.Descripcion.StartsWith(Criterio) ||
                                                                              p.TipoCombustible.Descripcion.StartsWith(Criterio)).ToListAsync());

        }

        // GET: Vehiculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos
                .Include(v => v.Marca)
                .Include(v => v.Modelo)
                .Include(v => v.TipoCombustible)
                .Include(v => v.TipoVehiculo)
                .FirstOrDefaultAsync(m => m.IdVehiculo == id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            return View(vehiculo);
        }

        // GET: Vehiculos/Create
        public IActionResult Create()
        {

            ViewData["IdMarca"] = new SelectList(_context.Marcas, "IdMarca", "Descripcion");
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "IdModelo", "Descripcion");
            ViewData["IdTipoCombustible"] = new SelectList(_context.TipoCombustibles, "IdTipoCombustible", "Descripcion");
            ViewData["IdTipoVehiculo"] = new SelectList(_context.TipoVehiculos, "IdTipoVehiculo", "Descripcion");
            return View();
        }

        // POST: Vehiculos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVehiculo,Descripcion,NumChasis,NumPlaca,IdTipoVehiculo,IdMarca,IdModelo,IdTipoCombustible,Estado")] Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "IdMarca", "Descripcion", vehiculo.IdMarca);
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "IdModelo", "Descripcion", vehiculo.IdModelo);
            ViewData["IdTipoCombustible"] = new SelectList(_context.TipoCombustibles, "IdTipoCombustible", "Descripcion", vehiculo.IdTipoCombustible);
            ViewData["IdTipoVehiculo"] = new SelectList(_context.TipoVehiculos, "IdTipoVehiculo", "Descripcion", vehiculo.IdTipoVehiculo);
            return View(vehiculo);
        }

        // GET: Vehiculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "IdMarca", "Descripcion", vehiculo.IdMarca);
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "IdModelo", "Descripcion", vehiculo.IdModelo);
            ViewData["IdTipoCombustible"] = new SelectList(_context.TipoCombustibles, "IdTipoCombustible", "Descripcion", vehiculo.IdTipoCombustible);
            ViewData["IdTipoVehiculo"] = new SelectList(_context.TipoVehiculos, "IdTipoVehiculo", "Descripcion", vehiculo.IdTipoVehiculo);
            return View(vehiculo);
        }

        // POST: Vehiculos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehiculo,Descripcion,NumChasis,NumPlaca,IdTipoVehiculo,IdMarca,IdModelo,IdTipoCombustible,Estado")] Vehiculo vehiculo)
        {
            if (id != vehiculo.IdVehiculo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehiculoExists(vehiculo.IdVehiculo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "IdMarca", "Descripcion", vehiculo.IdMarca);
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "IdModelo", "Descripcion", vehiculo.IdModelo);
            ViewData["IdTipoCombustible"] = new SelectList(_context.TipoCombustibles, "IdTipoCombustible", "Descripcion", vehiculo.IdTipoCombustible);
            ViewData["IdTipoVehiculo"] = new SelectList(_context.TipoVehiculos, "IdTipoVehiculo", "Descripcion", vehiculo.IdTipoVehiculo);
            return View(vehiculo);
        }

        // GET: Vehiculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos
                .Include(v => v.Marca)
                .Include(v => v.Modelo)
                .Include(v => v.TipoCombustible)
                .Include(v => v.TipoVehiculo)
                .FirstOrDefaultAsync(m => m.IdVehiculo == id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            return View(vehiculo);
        }

        // POST: Vehiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            _context.Vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculos.Any(e => e.IdVehiculo == id);
        }

        [HttpGet]
        public JsonResult GetModeloList(int MarcaId)
        {
            var modelolist = new SelectList(_context.Modelos.Where(c => c.Marca.IdMarca == MarcaId), "IdModelo", "Descripcion");
            return Json(modelolist);

        }


    }
}
