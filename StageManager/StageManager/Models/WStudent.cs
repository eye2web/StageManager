﻿using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStudent:Wrapper<studentset>
    {
        public WStudent(studentset set)
            : base(set)
        { }
    }
}
