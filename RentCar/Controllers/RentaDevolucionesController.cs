using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentCar.Data;
using RentCar.Models.RentCarModels;

namespace RentCar.Controllers
{
    public class RentaDevolucionesController : Controller
    {
        private readonly RentCarDbContext _context;
        

        public RentaDevolucionesController(RentCarDbContext context)
        {
            _context = context;
        }




        // GET: RentaDevoluciones
        public async Task<IActionResult> Index(string Criterio = null)
        {
            var rentCarDbContext = _context.RentasDevoluciones.Include(r => r.Cliente).Include(r => r.Empleado).Include(r => r.Inspeccion).Include(r => r.Vehiculo);

         
            return View(await rentCarDbContext.Where(p => Criterio == null || p.Vehiculo.Descripcion.StartsWith(Criterio) ||
                                                                              p.Empleado.Nombre.StartsWith(Criterio) || p.Empleado.Nombre.StartsWith(Criterio) ||
                                                                              p.IdInspeccion.ToString().StartsWith(Criterio) || p.FechaRenta.ToString().StartsWith(Criterio) ||
                                                                              p.FechaDevolucion.ToString().StartsWith(Criterio) || p.MontoDiario.ToString().StartsWith(Criterio) ||
                                                                              p.CantidadDias.ToString().StartsWith(Criterio) || p.Comentario.StartsWith(Criterio)).ToListAsync());
        }

        // GET: RentaDevoluciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentaDevolucion = await _context.RentasDevoluciones
                .Include(r => r.Cliente)
                .Include(r => r.Empleado)
                .Include(r => r.Inspeccion)
                .Include(r => r.Vehiculo)
                .FirstOrDefaultAsync(m => m.IdRenta == id);
            if (rentaDevolucion == null)
            {
                return NotFound();
            }

            return View(rentaDevolucion);
        }

        // GET: RentaDevoluciones/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre");
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre");
            ViewData["IdVehiculo"] = new SelectList(_context.Vehiculos.Where(c => c.Estado == true), "IdVehiculo", "Descripcion");
            ViewData["IdInspeccion"] = new SelectList(_context.Inspecciones, "IdTransaccion", "IdTransaccion");
            return View();
        }

        // POST: RentaDevoluciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRenta,IdCliente,IdEmpleado,IdInspeccion,IdVehiculo,FechaRenta,FechaDevolucion,MontoDiario,CantidadDias,Comentario,Estado")] RentaDevolucion rentaDevolucion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentaDevolucion);
                Vehiculo vehiculo = (from r in _context.Vehiculos.Where(a => a.IdVehiculo == rentaDevolucion.IdVehiculo) select r).FirstOrDefault();
                vehiculo.Estado = false;
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", rentaDevolucion.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre", rentaDevolucion.IdEmpleado);
            ViewData["IdVehiculo"] = new SelectList(_context.Vehiculos.Where(c => c.Estado == true), "IdVehiculo", "Descripcion", rentaDevolucion.IdVehiculo);
            ViewData["IdInspeccion"] = new SelectList(_context.Inspecciones, "IdTransaccion", "IdTransaccion",rentaDevolucion.IdInspeccion);
            return View(rentaDevolucion);
        }

        // GET: RentaDevoluciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentaDevolucion = await _context.RentasDevoluciones.FindAsync(id);
            if (rentaDevolucion == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", rentaDevolucion.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre", rentaDevolucion.IdEmpleado);
            ViewData["IdVehiculo"] = new SelectList(_context.Vehiculos.Where(c => c.Estado == true), "IdVehiculo", "Descripcion", rentaDevolucion.IdVehiculo);
            ViewData["IdInspeccion"] = new SelectList(_context.Inspecciones, "IdTransaccion", "IdTransaccion", rentaDevolucion.IdInspeccion);
            return View(rentaDevolucion);
        }

        // POST: RentaDevoluciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRenta,IdCliente,IdEmpleado,IdInspeccion,IdVehiculo,FechaRenta,FechaDevolucion,MontoDiario,CantidadDias,Comentario,Estado")] RentaDevolucion rentaDevolucion)
        {
            if (id != rentaDevolucion.IdRenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentaDevolucion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentaDevolucionExists(rentaDevolucion.IdRenta))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", rentaDevolucion.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Nombre", rentaDevolucion.IdEmpleado);
            ViewData["IdVehiculo"] = new SelectList(_context.Vehiculos.Where(c => c.Estado == true), "IdVehiculo", "Descripcion", rentaDevolucion.IdVehiculo);
            ViewData["IdInspeccion"] = new SelectList(_context.Inspecciones, "IdTransaccion", "IdTransaccion", rentaDevolucion.IdInspeccion);
            return View(rentaDevolucion);
        }

        // GET: RentaDevoluciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentaDevolucion = await _context.RentasDevoluciones
                .Include(r => r.Cliente)
                .Include(r => r.Empleado)
                .Include(r => r.Inspeccion)
                .Include(r => r.Vehiculo)
                .FirstOrDefaultAsync(m => m.IdRenta == id);
            if (rentaDevolucion == null)
            {
                return NotFound();
            }

            return View(rentaDevolucion);
        }

        // POST: RentaDevoluciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentaDevolucion = await _context.RentasDevoluciones.FindAsync(id);
            _context.RentasDevoluciones.Remove(rentaDevolucion);
            Vehiculo vehiculo = (from v in _context.Vehiculos
                                 join r in _context.RentasDevoluciones
                                 on v.IdVehiculo equals r.IdVehiculo
                                 where r.IdRenta == id
                                 select v).FirstOrDefault();
            vehiculo.Estado = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentaDevolucionExists(int id)
        {
            return _context.RentasDevoluciones.Any(e => e.IdRenta == id);
        }

       
    public ActionResult Return(int id)
        {
            //var rentaDevolucion =  _context.RentasDevoluciones
            //   .Include(r => r.Cliente)
            //   .Include(r => r.Empleado)
            //   .Include(r => r.Inspeccion)
            //   .Include(r => r.Vehiculo)
            //   .FirstOrDefaultAsync(m => m.IdRenta == id);

            Vehiculo vehiculo = (from v in _context.Vehiculos
                                 join r in _context.RentasDevoluciones
                                 on v.IdVehiculo equals r.IdVehiculo
                                 where r.IdRenta == id
                                 select v).FirstOrDefault();
            vehiculo.Estado = true;

            RentaDevolucion rentaDevolucione = (from r in _context.RentasDevoluciones.Where(a => a.IdRenta == id) select r).FirstOrDefault();
            rentaDevolucione.Estado = true;
            rentaDevolucione.FechaDevolucion = DateTime.Now;
            _context.SaveChangesAsync();

            

            return RedirectToAction(nameof(Index));
        }
        

        [HttpGet]
        public JsonResult GetClienteList(int VehiculoId)
        {
            var clientelist = new SelectList(from c in _context.Clientes
                                             join i in _context.Inspecciones
                                             on c.IdCliente equals i.IdCliente
                                             where i.IdVehiculo == VehiculoId
                                             select c, "IdCliente", "Nombre");
            return Json(clientelist);

        }

        [HttpGet]
        public JsonResult GetEmpleadoList(int ClienteId)
        {
            var empleadoList = new SelectList(from r in _context.Empleados
                                              join  i in _context.Inspecciones 
                                              on r.IdEmpleado equals i.IdEmpleado
                                              where i.IdCliente == ClienteId select r, "IdEmpleado", "Nombre");
           
            //var inspeccionlist = new SelectList(_context.Inspecciones.Where(c => c.IdVehiculo == VehiculoId), "IdTransaccion", "IdTransaccion");
            return Json(empleadoList);

        }

        [HttpGet]
        public JsonResult GetInspeccionList(int VehiculoId)
        {
            var inspeccionList = new SelectList(_context.Inspecciones.Where(c => c.IdVehiculo == VehiculoId), "IdTransaccion", "IdTransaccion");

            //var inspeccionlist = new SelectList(_context.Inspecciones.Where(c => c.IdVehiculo == VehiculoId && c.IdCliente == ClienteId && c.IdEmpleado == EmpleadoId ), "IdTransaccion", "IdTransaccion");
            return Json(inspeccionList);

        }

        public ActionResult exportaAExcel(string Criterio = null)
        {
            var rentCarDbContext = _context.RentasDevoluciones.Include(r => r.Cliente).Include(r => r.Empleado).Include(r => r.Inspeccion).Include(r => r.Vehiculo);
            string fileName = "Renta.csv";
            string filePath = @"c:\tmp\" + fileName;
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine("sep=,"); //Indica a excel el separador a usar
            sw.WriteLine("IdRenta,IdCliente,IdEmpleado,IdInspeccion,IdVehiculo,Fecha Renta,Fecha Devolucion,Monto Diario,Cantidad de Dias,Comentario,Estado"); //Encabezado
            foreach (var i in _context.RentasDevoluciones.ToList())
            {
                sw.WriteLine(i.IdRenta + "," + i.IdCliente + "," + i.IdEmpleado + "," + i.IdInspeccion + "," + i.IdVehiculo + "," + i.FechaRenta + "," 
                             + i.FechaDevolucion + "," + i.MontoDiario + "," + i.CantidadDias + "," + i.Comentario + "," + i.Estado);
            }
            sw.Close();
            byte[] fileData = System.IO.File.ReadAllBytes(filePath);
            return File(fileData, "application/force-download", fileName);
        }
    }
}
