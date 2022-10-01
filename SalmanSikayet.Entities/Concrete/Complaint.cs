﻿using SalmanSikayet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.Entities.Concrete
{
    public class Complaint:Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }

    }
}
