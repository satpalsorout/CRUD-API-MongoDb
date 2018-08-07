using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AssignmentAPI.Models;
using Microsoft.AspNetCore.Cors;

namespace AssignmentAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Enrollement")]
    public class EnrollementController : Controller
    {
        // GET: api/Enrollement
        [HttpGet]
        public IEnumerable<EnrollementUser> Get()
        {
            Enrollement enrollement = new Enrollement();
            return enrollement.GetEnrollements();
        }

        // GET: api/Enrollement/5
        [HttpGet("{id}", Name = "Get")]
        public EnrollementUser Get(long id)
        {
            Enrollement enrollement = new Enrollement();
            return enrollement.GetEnrollementUser(id);
        }
        
        // POST: api/Enrollement
        [HttpPost]
        public bool Post([FromBody]EnrollementUser enrollementUser)
        {
            Enrollement enrollement = new Enrollement();
           return enrollement.AddEnrollementUser(enrollementUser);
        }
        
        // PUT: api/Enrollement/5
        [HttpPut("{id}")]
        public void Put(long id,[FromBody]EnrollementUser enrollementUser)
        {
            Enrollement enrollement = new Enrollement();
            enrollement.updateEnrollement(id, enrollementUser);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            Enrollement enrollement = new Enrollement();
            enrollement.deleteEnrollement(id);
        }
    }
}
