using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using AssignmentAPI.DAL;
namespace AssignmentAPI.Models
{
    public class Enrollement
    {

        public IEnumerable<EnrollementUser> GetEnrollements()
        {

            DataAccess dal = new DataAccess();
            return dal.GetEnrollements();
        }
        public bool AddEnrollementUser(EnrollementUser enrollementUser)
        {
            DataAccess dal = new DataAccess();
            return dal.AddEnrollementUser(enrollementUser); 
        }
            public EnrollementUser GetEnrollementUser(long id)
        {
            DataAccess dal = new DataAccess();
            return dal.GetEnrollementUser(id);
        }
        public void updateEnrollement(long id, EnrollementUser enrollementUser_)
        {
            DataAccess dal = new DataAccess();
            dal.updateEnrollement(id, enrollementUser_);
        }
        public void deleteEnrollement(long id)
        {
            DataAccess dal = new DataAccess();
            dal.deleteEnrollement(id);
        }
    }
}

