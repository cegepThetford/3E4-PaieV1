using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    class EmployePermanent
    {
        private int _numAssSoc;
        private string _nom;
        private decimal _salaire;

        public EmployePermanent(int nas, string nom, decimal sal)
        {
            _numAssSoc = nas;
            _nom = nom;
            _salaire = sal;
        }

        public int NumAssSoc { get { return _numAssSoc; } }
        public string Nom { get { return _nom; } }
        public decimal Salaire { get { return _salaire; } set { _salaire = value; } }

        public decimal calculerSalaireBrut()
        {
            return _salaire / 26.0m;
        }
    }
}
