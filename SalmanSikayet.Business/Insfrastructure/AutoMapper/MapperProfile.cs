using AutoMapper;
using SalmanSikayet.Entities.Concrete;
using SalmanSikayet.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.Business.Insfrastructure.AutoMapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Complaint, ComplaintDto>().ReverseMap();
        }
    }
}
