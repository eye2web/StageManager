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
        IEnumerable<Student> Studenten { get; }

        IEnumerable<Docent> Docenten { get; }

        IEnumerable<Bedrijf> Bedrijven { get; }

        IEnumerable<Bedrijfsbegeleider> Bedrijfsbegeleiders { get; }

        //void addStudent();

        //void addDocent();

        //void addBedrijf();

        //void addBedrijfsbegeleider();



    }
}
