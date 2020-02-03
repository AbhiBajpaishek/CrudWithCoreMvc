﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithCoreMvc.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dept Department { get; set; }
        public string Email { get; set; }
    }
}
