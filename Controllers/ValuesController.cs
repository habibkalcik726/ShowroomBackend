using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ShowroomBackend.Model;
using ShowroomBackend.Model.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShowroomBackend.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DataBaseContext _context;// = new DataBaseContext();
        public ValuesController(DataBaseContext context)
        {
            //_logger = logger;
            _context = context;

        }

        [HttpGet("Categories")]
        public JsonResult GetCategories()
        {
            var veri = _context.Category.ToList();

            return Json(veri);
        }


        [HttpGet("Category/{categoryId}")]
        public JsonResult GetProducts(int? categoryId)
        {
            var veri = _context.Product.ToList()
                .Where(x => x.categoryId == categoryId || categoryId == null);

            return Json(veri);
        }


        [HttpPost("CreateProduct")]
        public void CreateProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();

        }


        // GET: api/<controller>
        [HttpGet]

        public JsonResult Get()
        {
            //var list = new List<Product>();
            //var product = new Product()
            //{

            //    id = 3,
            //    productname = "mouse",
            //    price = 45,
            //    categoryId = 2,
            //    description = "Microsoft Mouse",
            //    imageUrl = "https://productimages.hepsiburada.net/s/7/550/8882971508786.jpg/format:webp"
            //};

            //list.Add(product);
            //list.Add(product);
            var veri = _context.Product.ToList();

            return Json(veri);// new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        [AllowAnonymous]
        public void Post([FromBody] Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
