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


        public static List<WStudent> SearchStudentSet(String searchString, String searchOpleiding)
        {

            if (searchString == null)
            {
                return (from student
                        in smE.studentsets.ToList()
                        where student.opleidingsets.Naam.ToLower().Contains(searchOpleiding.ToLower())
                        select new WStudent(student)).ToList();
            }
            else if(searchOpleiding == null)
            {
                return (from student
                        in smE.studentsets.ToList()
                        where student.persoonsets.Voornaam.ToLower().Contains(searchString.ToLower()) ||
                        student.persoonsets.Achternaam.ToLower().Contains(searchString.ToLower()) ||
                        student.Studentnummer.ToString().ToLower().Contains(searchString.ToLower())
                        select new WStudent(student)).ToList();
            }
            else
            {
                return (from student
                        in smE.studentsets.ToList()
                        where (student.persoonsets.Voornaam.ToLower().Contains(searchString.ToLower()) ||
                        student.persoonsets.Achternaam.ToLower().Contains(searchString.ToLower()) ||
                        student.Studentnummer.ToString().ToLower().Contains(searchString.ToLower())) &&
                        (student.opleidingsets.Naam.ToLower().Contains(searchOpleiding.ToLower()))
                        select new WStudent(student)).ToList();
            }
        }

        public static List<WDocent> SearchDocentSet(String searchString)
        {
            if (searchString == null)
            {
                return (from docent in smE.docentsets.ToList() select new WDocent(docent)).ToList();
            }
            else
            {
                return (from docent 
                            in smE.docentsets.ToList()
                            where (docent.persoonsets.Voornaam.ToLower().Contains(searchString.ToLower()) ||
                            docent.persoonsets.Achternaam.ToLower().Contains(searchString.ToLower()))
                        select new WDocent(docent)).ToList();
            }
        }

        public static List<WBedrijfsBegeleider> SearchBedrijfsBegeleiderSet()
        {
            return (from begeleider in smE.bedrijfsbegeleidersets.ToList() select new WBedrijfsBegeleider(begeleider)).ToList();
        }

        public static List<WOpleiding> SearchOpleidingSet()
        {
            return (from opleiding in smE.opleidingsets.ToList().OrderBy(o => o.Naam) select new WOpleiding(opleiding)).ToList();
        }

        public static List<WBedrijf> SearchBedrijfSet()
        {
            return (from bedrijf in smE.bedrijfsets.ToList() select new WBedrijf(bedrijf)).ToList();
        }

        public static List<WStage> SearchStageSet()
        {
            return (from stage in smE.stagesets.ToList() select new WStage(stage)).ToList();
        }
    }
}
