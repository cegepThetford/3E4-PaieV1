using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    public class EmployeHoraire
    {
        private int _numAssSoc;
        private string _nom;
        private decimal _tauxHoraire;
        private double _nbHeures; 

        public EmployeHoraire(int nas, string nom, decimal th)
        {
            _numAssSoc = nas;
            _nom = nom;
            _tauxHoraire = th;
            _nbHeures = 0;
        }

        public int NumAssSoc { get { return _numAssSoc; } }
        public string Nom { get { return _nom; } }
        public decimal TauxHoraire { get { return _tauxHoraire; } }
        public double NbHeures { get { return _nbHeures; } set { _nbHeures = value; } }
        public decimal calculerSalaireBrut()
        {
            decimal sal = (decimal) _nbHeures * _tauxHoraire;
            if (_nbHeures > 75)
                sal += (decimal) ((_nbHeures - 75) * 0.5) * _tauxHoraire;
            return sal;
        }
    }
}
