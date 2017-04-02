using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XFFilter.Models
{
    public class EmployeeRelationData : INotifyPropertyChanged
    {
        private int _relationID;

        public int RelationID
        {
            get
            {
                return _relationID;
            }
            set
            {
                if (_relationID != value)
                {
                    _relationID = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _eSalonID;

        public string eSalonID
        {
            get
            {
                return _eSalonID;
            }
            set
            {
                if (_eSalonID != value)
                {
                    _eSalonID = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _employeeType;

        public string EmployeeType
        {
            get
            {
                return _employeeType;
            }
            set
            {
                if (_employeeType != value)
                {
                    _employeeType = value;
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

        private string _cellPhone;

        public string CellPhone
        {
            get
            {
                return _cellPhone;
            }
            set
            {
                if (_cellPhone != value)
                {
                    _cellPhone = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _memo;

        public string Memo
        {
            get
            {
                return _memo;
            }
            set
            {
                if (_memo != value)
                {
                    _memo = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _createBy;
        public string CreateBy
        {
            get
            {
                return _createBy;
            }
            set
            {
                if (_createBy != value)
                {
                    _createBy = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                if (_createDate != value)
                {
                    _createDate = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _lastUpdateBy;
        public string LastUpdateBy
        {
            get
            {
                return _lastUpdateBy;
            }
            set
            {
                if (_lastUpdateBy != value)
                {
                    _lastUpdateBy = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTime _lastUpdateDate;
        public DateTime LastUpdateDate
        {
            get
            {
                return _lastUpdateDate;
            }
            set
            {
                if (_lastUpdateDate != value)
                {
                    _lastUpdateDate = value;
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
