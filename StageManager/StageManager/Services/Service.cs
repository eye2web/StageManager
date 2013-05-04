using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Services
{
    public class Service : IService
    {
        private readonly IFactory factory;
        private readonly List<Student> studenten;
        private readonly List<Docent> docenten;
        private readonly List<Bedrijf> bedrijven;
        private readonly List<Bedrijfsbegeleider> bedrijfsbegeleiders;

        public Service(IFactory factory)
        {
            this.factory = factory;

            this.studenten = new List<Student>();
            this.docenten = new List<Docent>();
            this.bedrijven = new List<Bedrijf>();
            this.bedrijfsbegeleiders = new List<Bedrijfsbegeleider>();
        }

        public IEnumerable<Student> Studenten
        {
            get { return studenten; }
        }

        public event EventHandler StudentenChanged;
        protected void OnStudentenChanged()
        {
            var handler = StudentenChanged;
            if (handler != null)
            {
                var e = EventArgs.Empty;
                handler(this, e);
            }
        }

        public IEnumerable<Docent> Docenten
        {
            get { return docenten; }
        }

        public event EventHandler DocentenChanged;

        protected void OnDocentenChanged()
        {
            var handler = DocentenChanged;
            if (handler != null)
            {
                var e = EventArgs.Empty;
                handler(this, e);
            }
        }

        public IEnumerable<Bedrijf> Bedrijven
        {
            get { return bedrijven; }
        }

        public event EventHandler BedrijvenChanged;

        protected void OnBedrijvenChanged()
        {
            var handler = BedrijvenChanged;
            if (handler != null)
            {
                var e = EventArgs.Empty;
                handler(this, e);
            }
        }

        public IEnumerable<Bedrijfsbegeleider> Bedrijfsbegeleiders
        {
            get { return bedrijfsbegeleiders; }
        }

        public event EventHandler BedrijfsbegeleidersChanged;

        protected void OnBedrijfsbegeleidersChanged()
        {
            var handler = BedrijfsbegeleidersChanged;
            if (handler != null)
            {
                var e = EventArgs.Empty;
                handler(this, e);
            }
        }
    }
}
