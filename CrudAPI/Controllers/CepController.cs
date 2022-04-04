// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Web;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using WebApiContrib.Formatting.JavaScriptSerializer;

// namespace CrudAPI.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]

//     public class CepController : ControllerBase
//     {
//         // public ActionResult Index() {
//         //     // ViewBag.Cep = Models.Cep.Search("79115351");
//         //     // return View();
//         // }

//         // public string Query(string cep) {
//         //     var cepObj = Models.Cep.Search(cep);
//         //     return new JavaScriptSerializer().Serialize(cepObj);
//         // }


//         [HttpGet("{CepId}")]
//         public async Task<ActionResult<User>> GetCepByIdAsync(int CepId) {
            
//             Cep cep = await Models.Cep.Search(CepId);

//             if (cep == null) {
//                 return NotFound();
//             } else
//             {
//                 return cep;
//             }     

//         }


        
//     }
// }