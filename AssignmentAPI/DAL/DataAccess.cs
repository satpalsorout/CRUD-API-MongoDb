using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using AssignmentAPI.Models;
using AssignmentAPI.mongodb;
namespace AssignmentAPI.DAL
{
    public class DataAccess
    {

        public IEnumerable<EnrollementUser> GetEnrollements()
        {
            MongoContext _mongoContext = new MongoContext();
            IEnumerable<EnrollementUser> lstEnrollementUser = _mongoContext._database.GetCollection<EnrollementUser>("enrollement").FindAll();
            return lstEnrollementUser;
        }
        public EnrollementUser GetEnrollementUser(long id)
        {
            MongoContext _mongoContext = new MongoContext();
            var enrollmentId = Query<EnrollementUser>.EQ(p => p.id, id);
            EnrollementUser _enrollementUser = _mongoContext._database.GetCollection<EnrollementUser>("enrollement").FindOne(enrollmentId);
            return _enrollementUser;
        }
        public bool AddEnrollementUser(EnrollementUser enrollementUser_)
        {
           
            MongoContext _mongoContext = new MongoContext();
            if (enrollementUser_.id <= 0)
            {
                enrollementUser_.id = _mongoContext._database.GetCollection<EnrollementUser>("enrollement").Count()+1;
            }
            var collection = _mongoContext._database.GetCollection<EnrollementUser>("enrollement");
            collection.Insert(enrollementUser_);
            return true;
        }
        public void updateEnrollement(long id, EnrollementUser enrollementUser_)
        {
            MongoContext _mongoContext = new MongoContext();
            var enrollmentId = Query<EnrollementUser>.EQ(p => p.id, id);
            var collection = _mongoContext._database.GetCollection<EnrollementUser>("enrollement");
            // Document Update which need Id and Data to Update  
            var result = collection.Update(enrollmentId, Update.Replace(enrollementUser_), UpdateFlags.None);
        }
        public void deleteEnrollement(long id)
        {
            MongoContext _mongoContext = new MongoContext();
            var enrollmentId = Query<EnrollementUser>.EQ(p => p.id, id);
            var collection = _mongoContext._database.GetCollection<EnrollementUser>("enrollement");
            var result = collection.Remove(enrollmentId, RemoveFlags.Single);
        }
    }
}
