using StageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.Services
{
    public class EntityService : IService
    {
        private readonly IFactory factory;
        private readonly Entities entities;

        public EntityService(
            IFactory factory,
            Entities entities)
        {
            this.factory = factory;
            this.entities = entities;
        }
        public IEnumerable<Student> Studenten
        {
            get { return entities.Studenten; }
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
            get { return entities.Docenten; }
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
            get { return entities.Bedrijven; }
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
            get { return entities.Bedrijfsbegeleiders; }
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
