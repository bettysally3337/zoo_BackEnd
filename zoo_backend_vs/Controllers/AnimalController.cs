// Controllers/AnimalController.cs

using MyBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MyBackend.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MyBackend.Controllers
{
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    [Produces("application/json")]
    // [Authorize(Policy = "AdminOnly")]
    public class AnimalController : ControllerBase
    {
        private readonly ZooDBContext _context;
        public AnimalController(ZooDBContext context)
        {
            _context = context;
        }

        // GET: api/animals
        [HttpGet("/Animals")]
        public ActionResult<IEnumerable<Animals>> GetAnimals()
        {
            Console.WriteLine("animals");
            return _context.Animals;
        }

        // GET: api/Animal/{A_Name_Ch}
        [HttpGet("{A_Name_Ch:maxlength(20)}")]
        public ActionResult<Animals> GetAnimal(String A_Name_Ch)
        {
            Console.WriteLine($"animal/{A_Name_Ch}");
            //var animal = _context.Animals.Entry(entity);
            IEnumerable<Animals> query = _context.Animals.Where(d => d.A_Name_Ch == A_Name_Ch);

            foreach (Animals d in query)
            {
                Console.WriteLine(d.A_Name_Ch);
            }
            return query.FirstOrDefault();
        }

        [HttpGet("/ZonedAnimal/{Zone:maxlength(20)=大貓熊}")]
        public async Task<ActionResult<IEnumerable<Animals>>> ZonedAnimalAsync(String Zone)
        {
            System.Diagnostics.Debug.WriteLine($"/ZonedAnimal/{Zone}");

            //var query1 = _context.Animals.Where(d => d.A_Location.Contains("非洲")).First();
            //System.Diagnostics.Debug.WriteLine($"/ZonedAnimal/{Zone}/{query1.idx}");

            // 除錯用
            //await _context.Animals.Where(d => d.A_Location.Contains(Zone)).ForEachAsync(item =>
            //{
            //    System.Diagnostics.Debug.WriteLine($"/ZonedAnimal/{Zone}/{item.idx}");
            //});

            IEnumerable<Animals> query = _context.Animals.Where(d => d.A_Location.Contains(Zone));
            
            //if (query == null)
            //{
            //    await _context.Animals.LoadAsync();
            //    query = _context.Animals.Where(d => d.A_Location.Contains(Zone));
            //}

            return query == null ? new List<Animals>() : query.ToList();
        }

        // POST: api/Customer
        // [HttpPost]
        // public ActionResult<Customer> CreateCustomer(Customer customer)
        // {
        //     if (customer == null)
        //     {
        //         return BadRequest();
        //     }
        //     _context.Customer.Add(customer);
        //     _context.SaveChanges();
        //     return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustomerId }, customer);
        // }
    }
}