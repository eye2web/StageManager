using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageManager.Models;

namespace StageManager.Services
{
    class DefaultFactory : IFactory
    {
        public Student CreateStudent()
        {
            return new Student
            {
                // Naam = naam,
                // Opleiding = opleiding
            };
        }
        public Docent CreateDocent()
        {
            return new Docent
            {
                // Naam = naam,
                // Opleiding = opleiding
            };
        }
    }
}
