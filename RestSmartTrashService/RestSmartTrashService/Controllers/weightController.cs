using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSmartTrashService.Model;

namespace RestSmartTrashService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class weightController : ControllerBase
    {
        string connectionString = "Server=tcp:projektgruppe.database.windows.net,1433;Initial Catalog=smartbiotrashcanDB;Persist Security Info=False;User ID=projektGruppe;Password=1234ABcd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // GET: api/weight
        [HttpGet]
        public void GetAllWeights()
        {
            //const string selectString = "select id, date, weight from weight order by id";
            //using (SqlConnection databaseConnection = new SqlConnection(connectionString))
            //{
            //    databaseConnection.Open();
            //    using (SqlCommand selectCommand = new SqlCommand(selectString, databaseConnection))
            //    {
            //        using (SqlDataReader reader = selectCommand.ExecuteReader())
            //        {
            //            List<weight> weightList = new List<weight>();
            //            while (reader.Read())
            //            {
            //                weight weight = ReadWeight(reader);
            //                weightList.Add(weight);
            //            }
            //            return weightList;
            //        }
            //    }
            //}
        }

        private static weight ReadWeight(IDataRecord reader)
        {
            int id = reader.GetInt32(0);
            string date = reader.GetString(1);
            string weightMeasure = reader.GetString(2);

            weight weight = new weight
            {
                id = id,
                date = date,
                weightMeasure= weightMeasure
            };
            return weight;
        }

        // GET: api/weight/5
        [HttpGet("{id}", Name = "Get1")]
        public IEnumerable<weight> Get(int id)
        {
            if (id == 1)
            {
                const string selectString = "select id, date, weight from weight order by id";
                using (SqlConnection databaseConnection = new SqlConnection(connectionString))
                {
                    databaseConnection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectString, databaseConnection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            List<weight> weightList = new List<weight>();
                            while (reader.Read())
                            {
                                weight weight = ReadWeight(reader);
                                weightList.Add(weight);
                            }
                            return weightList;
                        }
                    }
                }
            }
            if (id == 2)
            {
                const string selectString = "select id, date, weight from weight order by id";
                using (SqlConnection databaseConnection = new SqlConnection(connectionString))
                {
                    databaseConnection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectString, databaseConnection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            List<weight> weightList = new List<weight>();
                            while (reader.Read())
                            {
                                weight weight = ReadWeight(reader);
                                weightList.Add(weight);
                            }
                            return weightList;
                        }
                    }
                }

            }
            if (id == 3)
            {
                const string selectString = "select id, date, weight from weight order by id";
                using (SqlConnection databaseConnection = new SqlConnection(connectionString))
                {
                    databaseConnection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectString, databaseConnection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            List<weight> weightList = new List<weight>();
                            while (reader.Read())
                            {
                                weight weight = ReadWeight(reader);
                                weightList.Add(weight);
                            }
                            return weightList;
                        }
                    }
                }
            }
            if(id == 4)
            {
                const string selectString = "select id, date, weight from weight order by id";
                using (SqlConnection databaseConnection = new SqlConnection(connectionString))
                {
                    databaseConnection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectString, databaseConnection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            List<weight> weightList = new List<weight>();
                            while (reader.Read())
                            {
                                weight weight = ReadWeight(reader);
                                weightList.Add(weight);
                            }
                            return weightList;
                        }
                    }
                }
            }
            else
            {
                List<weight> weightList = new List<weight>();
                return weightList;
            }
        }

        // POST: api/weight
        [HttpPost]
        public int Post([FromBody] weight w)
        {
            const string postString = "INSERT INTO weight(date, weight) VALUES (@date, @weight)";
            using (SqlConnection databaseConnection = new SqlConnection(connectionString))
            {
                databaseConnection.Open();
                using (SqlCommand insertCommand = new SqlCommand(postString, databaseConnection))
                {
                    insertCommand.Parameters.AddWithValue("@date", w.date);
                    insertCommand.Parameters.AddWithValue("@weight", w.weightMeasure);
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    return rowsAffected;
                }
            }

        }

        // PUT: api/weight/5
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
