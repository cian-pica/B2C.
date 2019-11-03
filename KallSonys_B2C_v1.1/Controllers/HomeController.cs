using KallSonys_B2C_v1._1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace KallSonys_B2C_v1._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public async Task<ActionResult> Product()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://kallsonysservices.cian.net.co/rest/productos/getproductos");
            var productList = JsonConvert.DeserializeObject<List<Product>>(json);
            return View(productList);


        }
        

        public ActionResult Single()
        {
            
            ViewBag.Message = "Your contact page.";

            return View();
        }


        /// <summary>
        /// Método para consumir API Web
        /// </summary>
        /// <returns>Listado de productos deserializado de un Json</returns>
        public async Task<ActionResult> consumo()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://jsonplaceholder.typicode.com/posts");
            var productList = JsonConvert.DeserializeObject<List<UsuarioEjemplo>>(json);
            return View(productList);
        }


        [Authorize]
        public ActionResult Checkout()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Payment()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Faqs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Help()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //[HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }





        //    string sUrlRequest = "http://jsonplaceholder.typicode.com/posts";
        //    var json = new WebClient().DownloadString(sUrlRequest);

        //    JavaScriptSerializer ser = new JavaScriptSerializer();

        //List<UsuarioEjemplo> listProductos = new List<UsuarioEjemplo>();
        //listProductos = JsonConvert.DeserializeObject<List<UsuarioEjemplo>>(json);


        //Console.WriteLine(listProductos[0].id);
        //Console.WriteLine(listProductos[0].body);
        //Console.WriteLine(listProductos[0].title);
        //Console.WriteLine(listProductos[0].userId);


    }
}