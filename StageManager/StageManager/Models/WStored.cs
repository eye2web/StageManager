using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Models
{
    class WStored : Wrapper
    {
        public List<WStudent> SearchStudentSet(String searchString, String searchOpleiding)
        {

            if (searchString == null)
            {
                return (from student
                        in StageManagerEntities.studentsets.ToList()
                        where student.opleidingsets.Naam.ToLower().Contains(searchOpleiding.ToLower())
                        select new WStudent(student)).ToList();
            }
            else if (searchOpleiding == null)
            {
                return (from student
                        in StageManagerEntities.studentsets.ToList()
                        where student.persoonsets.Voornaam.ToLower().Contains(searchString.ToLower()) ||
                        student.persoonsets.Achternaam.ToLower().Contains(searchString.ToLower()) ||
                        student.Studentnummer.ToString().ToLower().Contains(searchString.ToLower())
                        select new WStudent(student)).ToList();
            }
            else
            {
                return (from student
                        in StageManagerEntities.studentsets.ToList()
                        where (student.persoonsets.Voornaam.ToLower().Contains(searchString.ToLower()) ||
                        student.persoonsets.Achternaam.ToLower().Contains(searchString.ToLower()) ||
                        student.Studentnummer.ToString().ToLower().Contains(searchString.ToLower())) &&
                        (student.opleidingsets.Naam.ToLower().Contains(searchOpleiding.ToLower()))
                        select new WStudent(student)).ToList();
            }
        }

        public List<WDocent> SearchDocentSet(String searchString)
        {
            if (searchString == null)
            {
                return (from docent in StageManagerEntities.docentsets.ToList() select new WDocent(docent)).ToList();
            }
            else
            {
                return (from docent
                            in StageManagerEntities.docentsets.ToList()
                        where (docent.persoonsets.Voornaam.ToLower().Contains(searchString.ToLower()) ||
                        docent.persoonsets.Achternaam.ToLower().Contains(searchString.ToLower()))
                        select new WDocent(docent)).ToList();
            }
        }

        public List<WBedrijfsBegeleider> SearchBedrijfsBegeleiderSet()
        {
            return (from begeleider in StageManagerEntities.bedrijfsbegeleidersets.ToList() select new WBedrijfsBegeleider(begeleider)).ToList();
        }

        public List<WOpleiding> SearchOpleidingSet()
        {
            return (from opleiding in StageManagerEntities.opleidingsets.ToList().OrderBy(o => o.Naam) select new WOpleiding(opleiding)).ToList();
        }

        public List<WBedrijf> SearchBedrijfSet()
        {
            return (from bedrijf in StageManagerEntities.bedrijfsets.ToList() select new WBedrijf(bedrijf)).ToList();
        }

        public List<WStage> SearchStageSet()
        {
            return (from stage in StageManagerEntities.stagesets.ToList() select new WStage(stage)).ToList();
        }
    }
}