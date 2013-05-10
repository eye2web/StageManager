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
        private readonly List<studentset> studenten;
        private readonly List<docentset> docenten;
        private readonly List<bedrijfset> bedrijven;
        private readonly List<bedrijfsbegeleiderset> bedrijfsbegeleiders;

        public Service(IFactory factory)
        {
            this.factory = factory;

            this.studenten = new List<studentset>();
            this.docenten = new List<docentset>();
            this.bedrijven = new List<bedrijfset>();
            this.bedrijfsbegeleiders = new List<bedrijfsbegeleiderset>();
        }

        public IEnumerable<studentset> Studenten
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

        public IEnumerable<docentset> Docenten
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

        public IEnumerable<bedrijfset> Bedrijven
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

        public IEnumerable<bedrijfsbegeleiderset> Bedrijfsbegeleiders
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
