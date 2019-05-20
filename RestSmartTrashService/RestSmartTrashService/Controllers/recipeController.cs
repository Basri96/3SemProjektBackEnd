using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSmartTrashService.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestSmartTrashService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class recipeController : ControllerBase
    {
        private static string recipeUri = "https://restsmarttrashservice.azurewebsites.net/api/recipe";

        public static async Task<IList<recipe>> GetRecipeAsync(int id)
        {
            string requestUri = recipeUri + "/" + id;
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(requestUri);
                IList<recipe> c = JsonConvert.DeserializeObject<IList<recipe>>(content);

                return c;
            }
        }
        string connectionString = "Server=tcp:projektgruppe.database.windows.net,1433;Initial Catalog=smartbiotrashcanDB;Persist Security Info=False;User ID=projektGruppe;Password=1234ABcd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
       
       
        private static recipe ReadRecipe(IDataRecord reader)
        {
            int id = reader.GetInt32(0);
            string dato = reader.GetString(1);
            string recipeDescription = reader.GetString(2);
            string recipeTitle = reader.GetString(3);
        
            recipe recipe = new recipe
            {
                id = id,
                dato = dato,
                recipeDescription = recipeDescription,
                recipeTitle = recipeTitle
            };
                return recipe;
            
        }

        // GET: api/recipe/5
        [HttpGet("{id}", Name = "Get2")]
        public IEnumerable<recipe> Get(int id)
        {
            const string selectString = "SELECT * FROM Recipe order by id DESC";
            using (SqlConnection databaseConnection = new SqlConnection(connectionString))
            {
                databaseConnection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectString, databaseConnection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        List<recipe> recipeList = new List<recipe>();
                        while (reader.Read())
                        {
                            recipe weight = ReadRecipe(reader);
                            recipeList.Add(weight);
                        }
                        return recipeList;
                    }
                }
            }
        }

        // POST: api/recipe
        [HttpPost]
        public int Post([FromBody] recipe r)
        {
            const string postString = "INSERT INTO recipe(dato, recipeDescription, recipeTitle ) VALUES (@dato, @recipe, @recipeDescription ,@recipeTitle)";
            using (SqlConnection databaseConnection = new SqlConnection(connectionString))
            {
                databaseConnection.Open();
                using (SqlCommand insertCommand = new SqlCommand(postString, databaseConnection))
                {
                    insertCommand.Parameters.AddWithValue("@dato", r.dato);
                    insertCommand.Parameters.AddWithValue("@recipeDescription", r.recipeDescription);
                    insertCommand.Parameters.AddWithValue("@recipeTitle", r.recipeTitle);
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }

        // PUT: api/recipe/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
