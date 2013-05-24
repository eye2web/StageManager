using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStored
    {
        public static stagemanagerEntities smE = new stagemanagerEntities();


        public static List<WStudent> SearchStudentSet(String searchString="")
        {
            List<WStudent> returnList = new List<WStudent>();
            List<studentsets> list = (from student 
                                          in  smE.studentsets.ToList()
                                      where student.persoonsets.Voornaam.ToLower().Contains(searchString.ToLower()) ||
                                      student.persoonsets.Achternaam.ToLower().Contains(searchString.ToLower()) ||
                                      student.opleidingsets.Naam.ToLower().Contains(searchString.ToLower()) ||
                                      student.Studentnummer.ToString().ToLower().Contains(searchString.ToLower()) 
                                      select student).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                returnList.Add(new WStudent(list[i]));
            }
            int j = 0;
            int.TryParse(searchString, out j);
            return returnList;
        }

        public static List<WDocent> SearchDocentSet()
        {
            List<WDocent> returnList = new List<WDocent>();
            List<docentsets> list = smE.docentsets.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                returnList.Add(new WDocent(list[i]));
            }

            return returnList;
        }
    }
}
