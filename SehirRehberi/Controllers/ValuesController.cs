using Microsoft.AspNetCore.Mvc;
using SehirRehberi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.Controllers
{
    public class ValuesController : Controller
    {
        private DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }


       [HttpGet("values")]
       public IActionResult GetValues()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var values = _context.Values.FirstOrDefault();
            return Ok(values);
        }       
    }
}
