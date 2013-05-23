using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Services
{
    public interface IService
    {
        IEnumerable<studentset> Studenten { get; }

        IEnumerable<docentset> Docenten { get; }

        IEnumerable<bedrijfset> Bedrijven { get; }

        IEnumerable<bedrijfsbegeleiderset> Bedrijfsbegeleiders { get; }

        //void addStudent();

        //void addDocent();

        //void addBedrijf();

        //void addBedrijfsbegeleider();



    }
}
