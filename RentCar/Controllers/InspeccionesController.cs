using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentCar.Data;
using RentCar.Models.RentCarModels;

namespace RentCar.Controllers
{
    public class InspeccionesController : Controller
    {
        private readonly RentCarDbContext _context;

        public InspeccionesController(RentCarDbContext context)
        {
            _context = context;
        }

        // GET: Inspecciones
        public async Task<IActionResult> Index(string Criterio = null)
        {
            var rentCarDbContext = _context.Inspecciones.Include(i => i.Cliente).Include(i => i.Empleado).Include(i => i.Vehiculo);
            return View(await rentCarDbContext.Where(p => Criterio == null || p.Vehiculo.Descripcion.StartsWith(Criterio) ||
                                                                            p.Empleado.Nombre.StartsWith(Criterio) || p.Empleado.Nombre.StartsWith(Criterio) ||
                                                                              p.CantidadCombustible.ToString().StartsWith(Criterio) || p.Fecha.ToString().StartsWith(Criterio)).ToListAsync());
        }

        // GET: Inspecciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccion = await _context.Inspecciones
                .Include(i => i.Cliente)
                .Include(i => i.Empleado)
                .Include(i => i.Vehiculo)
                .FirstOrDefaultAsync(m => m.IdTransaccion == id);
            if (inspeccion == null)
            {
                return NotFound();
            }

            return View(inspeccion);
        }

        // GET: Inspecciones/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre");
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre");
            ViewData["IdVehiculo"] = new SelectList(_context.Vehiculos.Where(c => c.Estado == true), "IdVehiculo", "Descripcion");
            return View();
        }

        // POST: Inspecciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTransaccion,IdVehiculo,IdCliente,IdEmpleado,Ralladura,GomaRepuesta,Gato,RoturaCristal,PrimeraGoma,SegundaGoma,TerceraGoma,CuartaGoma,CantidadCombustible,Fecha,Estado")] Inspeccion inspeccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inspeccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", inspeccion.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre", inspeccion.IdEmpleado);
            ViewData["IdVehiculo"] = new SelectList(_context.Vehiculos.Where(c => c.Estado == true), "IdVehiculo", "Descripcion", inspeccion.IdVehiculo);
            return View(inspeccion);
        }

        // GET: Inspecciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccion = await _context.Inspecciones.FindAsync(id);
            if (inspeccion == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", inspeccion.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre", inspeccion.IdEmpleado);
            ViewData["IdVehiculo"] = new SelectList(_context.Vehiculos.Where(c => c.Estado == true), "IdVehiculo", "Descripcion", inspeccion.IdVehiculo);
            return View(inspeccion);
        }

        // POST: Inspecciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTransaccion,IdVehiculo,IdCliente,IdEmpleado,Ralladura,GomaRepuesta,Gato,RoturaCristal,PrimeraGoma,SegundaGoma,TerceraGoma,CuartaGoma,CantidadCombustible,Fecha,Estado")] Inspeccion inspeccion)
        {
            if (id != inspeccion.IdTransaccion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inspeccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InspeccionExists(inspeccion.IdTransaccion))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", inspeccion.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre", inspeccion.IdEmpleado);
            ViewData["IdVehiculo"] = new SelectList(_context.Vehiculos.Where(c => c.Estado == true), "IdVehiculo", "Descripcion", inspeccion.IdVehiculo);
            return View(inspeccion);
        }

        // GET: Inspecciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccion = await _context.Inspecciones
                .Include(i => i.Cliente)
                .Include(i => i.Empleado)
                .Include(i => i.Vehiculo)
                .FirstOrDefaultAsync(m => m.IdTransaccion == id);
            if (inspeccion == null)
            {
                return NotFound();
            }

            return View(inspeccion);
        }

        // POST: Inspecciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inspeccion = await _context.Inspecciones.FindAsync(id);
            _context.Inspecciones.Remove(inspeccion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InspeccionExists(int id)
        {
            return _context.Inspecciones.Any(e => e.IdTransaccion == id);
        }
    }
}
