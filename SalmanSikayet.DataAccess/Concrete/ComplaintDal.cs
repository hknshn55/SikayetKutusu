using SalmanSikayet.DataAccess.Abstract;
using SalmanSikayet.DataAccess.Concrete.Context;
using SalmanSikayet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.DataAccess.Concrete
{
    public class ComplaintDal:RepositoryBase<Complaint>,IComplaintDal
    {
        public ComplaintDal(SalmanSikayetContext context):base(context)
        {
        }
    }
}
