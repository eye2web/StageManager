﻿using Caliburn.Micro;
using StageManager.Models;
using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class KoppelViewModel : PropertyChanged
    {
        private WStage stage;

        public WStage Stage
        {
            get { return stage; }
            set { stage = value;
            KoppelStudentNaam = stage.studentset.Voornaam + " " + stage.studentset.Achternaam;
            NotifyOfPropertyChange(()=>CanTweedeLezer);
            NotifyOfPropertyChange(() => KoppelStudentNaam);
            }//TODO Notify
        }

        private String koppelStudentNaam = "<geselecteerde student>";
        public String KoppelStudentNaam
        {

            get { return koppelStudentNaam; }
            set
            {
                koppelStudentNaam = value;
                NotifyOfPropertyChange(() => KoppelStudentNaam);
            }
        }

        private WDocent selectedDocent;
        public Object SelectedDocent
        {

            get { return selectedDocent; }
            set
            {
                selectedDocent = new WStored().SearchDocentSet(value.GetType().GetProperty("Voornaam").GetMethod.Invoke(value, null).ToString()).First();
                KoppelDocent = selectedDocent;
                NotifyOfPropertyChange(() => SelectedDocent);
            }
        }

        private WDocent koppelDocent;
        public WDocent KoppelDocent
        {

            get { return koppelDocent; }
            set
            {
                koppelDocent = value;
                KoppelDocentNaam = koppelDocent.Achternaam + ", " + koppelDocent.Voornaam;
                NotifyOfPropertyChange(() => KoppelDocent);
            }
        }

        private String koppelDocentNaam = "<geselecteerde docent>";
        public String KoppelDocentNaam
        {

            get { return koppelDocentNaam; }
            set
            {
                koppelDocentNaam = value;
                NotifyOfPropertyChange(() => KoppelDocentNaam);
            }
        }

        public Boolean CanTweedeLezer
        {
            get { return Stage!=null? Stage.GetType()== typeof(WEindStage):false;
            }
        }

        private Dictionary<Object, WDocent> list;
        public Dictionary<Object, WDocent> List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
                NotifyOfPropertyChange(() => List);
            }
        }

        private List<Object> gridContents;
        public List<object> GridContents
        {
            get
            {
                return gridContents;
            }
            set
            {
                gridContents = value;
                NotifyOfPropertyChange(() => GridContents);
            }
        }



        public void TweedeLezer()
        {
            Main.ChangeButton("");//TODO!!
        }

        public KoppelViewModel(MainViewModel main)
            : base(main)
        {
            Main = main;
            list = new Dictionary<object, WDocent>();
            list = (new WStored().SearchDocentSet("").ToDictionary(t => (Object)new
                    {
                        Voornaam = t.Voornaam,
                        Achternaam = t.Achternaam,
                        Uren = t.Rest(),
                        Kennisgebied = t.tool_vaardigheidset.First().Naam,
                        Afstand = 500
                    }, t => t));


            GridContents = list.Keys.ToList();
        }

        public KoppelViewModel(MainViewModel main, WStage stage)
            :this(main)
        {
            Stage = stage;
        }

        public override void update(object[] o)
        {
            try
            {
                Stage = (WStage)o[1];
            }
            catch (Exception)
            {   
            }
        }

        public void Koppelen()
        {
            Stage.docentsets = KoppelDocent;            
            Wrapper myWrapper = new Wrapper();
            myWrapper.forceSync();
            Main.ChangeButton("Zoek", new List<Object>(), Services.Clear.All);
        }

    }
}
