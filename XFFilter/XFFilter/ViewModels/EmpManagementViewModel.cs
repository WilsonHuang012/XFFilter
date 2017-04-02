using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using System.Collections.ObjectModel;
using XFFilter.Models;
using Xamarin.Forms;
namespace XFFilter.ViewModels
{
    public class EmpManagementViewModel : BaseViewModel
    {
        private string _eSalonID;

        public EmpManagementViewModel(string _eSalonID)
        {
            this._eSalonID = _eSalonID;
            EmpManagement = new ObservableCollection<EmpManagement>();
            FilterEmpManagement = new ObservableCollection<EmpManagement>();
            BuildReservationData(_eSalonID);
        }

        public void BuildReservationData(string eSalonID)
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                EmpManagement.Clear();
                //Load Data from Server
                List<EmpManagement> managementList = LoadData(eSalonID);
                EmpManagement = new ObservableCollection<EmpManagement>(managementList);
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("訊息", "讀取人員資料錯誤 " + ex, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private List<EmpManagement> LoadData(string eSalonID)
        {
            List<EmpManagement> list = new List<Models.EmpManagement>();

            list.Add(new Models.EmpManagement()
            {
                Employee = new Employee()
                {
                    Name = "DSDSDS",
                    EmployeeID = "d000000001"
                },
                EmployeeRelationData  = new EmployeeRelationData()
                {
                      RelationID = 1,
                      eSalonID = "e000000001",
                      EmployeeType = "DS",
                      EmployeeID = "d000000001",
                      CellPhone = "0938765091",
                      Email = "DS@gamil.com",
                      Memo = "",
                      CreateBy = "e000000001",
                      CreateDate = DateTime.Now,
                      LastUpdateBy = "e000000001",
                      LastUpdateDate = DateTime.Now
                },
                Relation = "Related"
            });

            list.Add(new Models.EmpManagement()
            {
                Employee = new Employee()
                {
                    Name = "AAA",
                    EmployeeID = "a000000002"
                },
                EmployeeRelationData = new EmployeeRelationData()
                {
                    RelationID = 2,
                    eSalonID = "e000000001",
                    EmployeeType = "A",
                    EmployeeID = "a000000002",
                    CellPhone = "0912345678",
                    Email = "AAA@gamil.com",
                    Memo = "",
                    CreateBy = "e000000001",
                    CreateDate = DateTime.Now,
                    LastUpdateBy = "e000000001",
                    LastUpdateDate = DateTime.Now
                },
                Relation = "Related"
            });


            list.Add(new Models.EmpManagement()
            {
                Employee = new Employee()
                {
                    Name = "",
                    EmployeeID = ""
                },
                EmployeeRelationData = new EmployeeRelationData()
                {
                    RelationID = 3,
                    eSalonID = "e000000001",
                    EmployeeType = "D",
                    EmployeeID = "",
                    CellPhone = "0987654321",
                    Email = "DDD@gamil.com",
                    Memo = "",
                    CreateBy = "e000000001",
                    CreateDate = DateTime.Now,
                    LastUpdateBy = "e000000001",
                    LastUpdateDate = DateTime.Now
                },
                Relation = "NotRelated"
            });


            return list;
        }

        public void FilterReservationData(string filter)
        {
            FilterEmpManagement = new ObservableCollection<EmpManagement>(EmpManagement.Where(p => p.EmployeeRelationData.EmployeeType == filter));
        }

        public ObservableCollection<EmpManagement> EmpManagement { get; set; }
        public ObservableCollection<EmpManagement> FilterEmpManagement { get; set; }
    }
}
