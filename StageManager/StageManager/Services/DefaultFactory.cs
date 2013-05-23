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
        public studentset CreateStudent()
        {
            return new studentset
            {
                // Naam = naam,
                // Opleiding = opleiding
            };
        }
        public docentset CreateDocent()
        {
            return new docentset
            {
                // Naam = naam,
                // Opleiding = opleiding
            };
        }
    }
}
