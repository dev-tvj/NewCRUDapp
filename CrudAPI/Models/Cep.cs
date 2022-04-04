// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using System.Text;
// using System.Net;
// using System.IO;
// using WebApiContrib.Formatting.JavaScriptSerializer;

// namespace CrudAPI.Models
// {
//     public class Cep
//     {
//         public string CEP { get; set; }

//         public string Street { get; set; }

//         public string Number { get; set; }

//         public string District { get; set; }

//         public string City { get; set; }

//         public string State { get; set; }


//         public static Cep Search(string cep) {

            
//             var cepObj = new Cep();

//             var url = "https://viacep.com.br/ws/" + cep + "/json/";

//             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
//             request.AutomaticDecompression = DecompressionMethods.Gzip;

//             string json = string.Empty;
//             using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
//             using (Stream stream = response.GetResponseStream())
//             using (StreamReader reader = new StreamReader(stream))
//             {
//                 json = reader.ReadToEnd();
//             }

//             JavaScriptSerializer json_serializer = new JavaScriptSerializer();
//             JsonCepObject cepJson = json_serializer.Deserialize<JsonCepObject>(json);

//             cepObj.CEP = cepJson.cep;
//             cepObj.Street = cepJson.logradouro;
//             cepObj.District = cepJson.bairro;
//             cepObj.City = cepJson.localidade;
//             cepObj.State = cepJson.uf;

//             return cepObj;

//         }
        
//     }
// }