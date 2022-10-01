using SalmanSikayet.Entities.Concrete;
using SalmanSikayet.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.Business.Abstract
{
    public interface IComplaintService
    {
       Task< List<Complaint>> GetAllAsync();
        Task<List<Complaint>> DescriptionContainsListAsync(string word);
        Task AddAsync(ComplaintDto complaintDto);
    }
}
