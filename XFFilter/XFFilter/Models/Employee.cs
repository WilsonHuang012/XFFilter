using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XFFilter.Models
{
    public class Employee : INotifyPropertyChanged
    {
        private string _employeeName;
        public string Name
        {
            get
            {
                return _employeeName;
            }
            set
            {
                if (_employeeName != value)
                {
                    _employeeName = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _employeeID;
        public string EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                if (_employeeID != value)
                {
                    _employeeID = value;
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
