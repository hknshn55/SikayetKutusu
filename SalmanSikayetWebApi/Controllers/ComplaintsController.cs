using Microsoft.AspNetCore.Mvc;
using SalmanSikayet.Business.Abstract;
using SalmanSikayet.Entities.Concrete;
using SalmanSikayet.Entities.Dtos;
using SalmanSikayet.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalmanSikayetWebApi.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class ComplaintsController : ControllerBase
    {
        private readonly IComplaintService _complaintService;

        public ComplaintsController(IComplaintService complaintService)
        {
            _complaintService = complaintService;
        }

        [HttpPost]
        public async Task<IActionResult> Complain(ComplaintDto complaintDto)
        {
            await _complaintService.AddAsync(complaintDto);
            return Ok(Message.Başarılı.ToString());
        }

        [HttpGet]
        public IActionResult Complaints()
        {
            List<Complaint> complaints = _complaintService.GetAllAsync().Result;
            return Ok(complaints);
        }

        [HttpGet("{word}")]
        public IActionResult ComplaintsFind(string word)
        {
            List<Complaint> complaints = _complaintService.DescriptionContainsListAsync(word).Result;
            if (complaints is null)
            {
                return BadRequest(Message.Başarısız.ToString());
            }
            return Ok(complaints);
        }
    }
}
