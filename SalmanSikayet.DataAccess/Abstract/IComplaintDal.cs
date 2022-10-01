using SalmanSikayet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.DataAccess.Abstract
{
    public interface IComplaintDal:IRepository<Complaint>
    {
        //özel işlem varsa alırız.
    }
}
