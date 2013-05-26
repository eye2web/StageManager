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


        public static List<WStudent> SearchStudentSet(String searchString = "")
        {
            return (from student
                    in smE.studentsets.ToList()
                    where student.persoonsets.Voornaam.ToLower().Contains(searchString.ToLower()) ||
                    student.persoonsets.Achternaam.ToLower().Contains(searchString.ToLower()) ||
                    student.opleidingsets.Naam.ToLower().Contains(searchString.ToLower()) ||
                    student.Studentnummer.ToString().ToLower().Contains(searchString.ToLower())
                    select new WStudent(student)).ToList();
        }

        public static List<WDocent> SearchDocentSet()
        {
            return (from docent in smE.docentsets select new WDocent(docent)).ToList();
        }

        public static List<WBedrijfsBegeleider> SearchBedrijfsBegeleiderSet()
        {
            return (from begeleider in smE.bedrijfsbegeleidersets select new WBedrijfsBegeleider(begeleider)).ToList();
        }
    }
}
