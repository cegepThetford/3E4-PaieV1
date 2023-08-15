using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie_Affaires
{
    class Entreprise
    {
        private Dictionary<int,EmployePermanent> _employesPermanents;
        private Dictionary<int,EmployeHoraire> _employesHoraires;
        private Dictionary<int,Pigiste> _pigistes;

        public Entreprise()
        {
            _employesPermanents = new Dictionary<int,EmployePermanent>();
            _employesHoraires = new Dictionary<int,EmployeHoraire>();
            _pigistes = new Dictionary<int,Pigiste>();
        }

        public Dictionary<int, EmployePermanent> EmployesPermanents { get { return _employesPermanents; } }
        public Dictionary<int, EmployeHoraire> EmployesHoraires { get { return _employesHoraires; } }
        public Dictionary<int, Pigiste> Pigistes { get { return _pigistes; } }

        public EmployePermanent getEmployePermanent(int nas) { return _employesPermanents[nas]; }
        public EmployeHoraire getEmployeHoraire(int nas) { return _employesHoraires[nas]; }
        public Pigiste getPigiste(int nas) { return _pigistes[nas]; }

        public void ajouterEmployePermanent(EmployePermanent emp) { _employesPermanents.Add(emp.NumAssSoc, emp); }
        public void ajouterEmployeHoraire(EmployeHoraire emp) { _employesHoraires.Add(emp.NumAssSoc, emp); }
        public void ajouterPigiste(Pigiste emp) { _pigistes.Add(emp.NumAssSoc, emp); }

        public Dictionary<int, decimal> calculerSalairesBruts()
        {
            Dictionary<int, decimal> salaires = new Dictionary<int, decimal>();
            foreach (EmployePermanent emp in _employesPermanents.Values)
                salaires.Add(emp.NumAssSoc, emp.calculerSalaireBrut());
            foreach (EmployeHoraire emp in _employesHoraires.Values)
                salaires.Add(emp.NumAssSoc, emp.calculerSalaireBrut());
            foreach (Pigiste emp in _pigistes.Values)
                salaires.Add(emp.NumAssSoc, emp.calculerSalaireBrut());
            return salaires;
        }
    }
}
