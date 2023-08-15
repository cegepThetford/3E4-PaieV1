using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    class Contrat
    {
        private int _numero;
        private string _description;
        private DateTime _dateDebut, _dateFin;
        private decimal _montant;

        public Contrat(int no, string desc, DateTime dd, DateTime df, decimal mnt)
        {
            _numero = no;
            _description = desc;
            _dateDebut = dd;
            _dateFin = df;
            _montant = mnt;
        }

        public int Numero { get { return _numero; } }
        public string Description { get { return _description; } }
        public DateTime DateDebut { get { return _dateDebut; } }
        public DateTime DateFin { get { return _dateFin; } }
        public decimal Montant { get { return _montant; } }
    }
}
