using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    class Pigiste
    {
        private int _numAssSoc;
        private string _nom;
        private Contrat _contrat;

        public Pigiste(int nas, string nom, Contrat cont)
        {
            _numAssSoc = nas;
            _nom = nom;
            _contrat = cont;
        }

        public int NumAssSoc { get { return _numAssSoc; } }
        public string Nom { get { return _nom; } }
        public Contrat Contrat { get { return _contrat; } set { _contrat = value; } }

        public decimal calculerSalaireBrut()
        {
            TimeSpan ts = _contrat.DateFin - _contrat.DateDebut;
            return _contrat.Montant / 26.0m; 
        }
    }
}
