using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
namespace XFFilter.Models
{
    public class EmpManagement : ObservableObject
    {

        public EmployeeRelationData EmployeeRelationData { get; set; }

        public Employee Employee { get; set; }

        private string _Relation;
        public string Relation
        {
            get
            {
                return _Relation;
            }
            set
            {
                SetProperty(ref _Relation, value);
            }
        }
    }
}
