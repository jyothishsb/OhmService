using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OhmService.Models;
using System.Web.Http.Cors;


namespace OhmService.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ResistorController : ApiController
    {
        // GET: api/Resistor/5/6
        public OhmResponse Get(string bandA, string bandB, string bandC, string bandD )
        {
            OhmValueCalculator resistanceCalculator = new OhmValueCalculator();
            return resistanceCalculator.getOhmValue(bandA, bandB, bandC, bandD);
        }

    }
}
