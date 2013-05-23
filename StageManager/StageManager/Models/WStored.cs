using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStored
    {
        public static List<WStudent> SearchStudentSet(String searchString)
        {
            List<WStudent> returnList = new List<WStudent>();
            stagemanagerEntities sme = new stagemanagerEntities();
            List<studentset> list = sme.SearchStudentSet(searchString).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                returnList.Add(new WStudent(list[i]));
            }

            return returnList;
        }

        public static List<WDocent> SearchDocentSet()
        {
            List<WDocent> returnList = new List<WDocent>();
            stagemanagerEntities sme = new stagemanagerEntities();
            List<docentset> list = sme.SearchDocentSet().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                returnList.Add(new WDocent(list[i]));
            }

            return returnList;
        }
    }
}
