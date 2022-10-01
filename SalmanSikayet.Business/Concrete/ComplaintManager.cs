using AutoMapper;
using SalmanSikayet.Business.Abstract;
using SalmanSikayet.DataAccess.Abstract;
using SalmanSikayet.Entities.Concrete;
using SalmanSikayet.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.Business.Concrete
{
    public class ComplaintManager:IComplaintService
    {
        private readonly IComplaintDal _complaintDal;
        private readonly IMapper _mapper;

        public ComplaintManager(IComplaintDal complaintDal, IMapper mapper)
        {
            _complaintDal = complaintDal;
            _mapper = mapper;
        }

        public async Task AddAsync(ComplaintDto complaintDto)
        {
            Complaint complaint = _mapper.Map<Complaint>(complaintDto);
            await _complaintDal.Add(complaint);
        }

        public async Task<List<Complaint>> DescriptionContainsListAsync(string word)
        {
            return await _complaintDal.GetAll(x => x.Description.Contains(word));
        }

        public async Task<List<Complaint>> GetAllAsync()
        {
            return await _complaintDal.GetAll();
        }
    }
}
