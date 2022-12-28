﻿using FinalProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities.Concrete
{
    public class Teacher : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BranchID { get; set; }
    }
}
