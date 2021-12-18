using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using harvest_api.Models;
using harvest_api.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace harvest_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrchardController : ControllerBase
    {
        public AppDb Db { get; }
        public OrchardController(AppDb db)
        {
            Db = db;
        }

        /// <summary>
        /// Get all orchards from harvest database
        /// </summary>
        /// <returns>Data</returns>
        [HttpGet]
        public async Task<List<Orchard>> Get()
        {
            var orchards = new List<Orchard>();

            await Db.Connection.OpenAsync();
            using var command = Db.Connection.CreateCommand();
            command.CommandText = $@"SELECT {(nameof(Harvest.orchardId))}, {(nameof(Harvest.orchardName))} FROM data GROUP BY {(nameof(Harvest.orchardId))};";
            using var reader = await command.ExecuteReaderAsync();
            while (reader.HasRows)
            {
                while (await reader.ReadAsync())
                    orchards.Add(new Orchard
                    {
                        id = reader.GetString(0),
                        name = reader.GetString(1),
                    });
                await reader.NextResultAsync();
            }

            return orchards;
        }
    }
}
