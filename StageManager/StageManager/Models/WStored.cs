﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStored
    {
        public static List<WStudent> SearchStudentSet()
        {
            List<WStudent> returnList = new List<WStudent>();
            stagemanagerEntities sme = new stagemanagerEntities();
            List<studentsets>list= sme.SearchStudentSet().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                returnList.Add(new WStudent(list[i]));
            }

                return returnList;
        }
    }
}