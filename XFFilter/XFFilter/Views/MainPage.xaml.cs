using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFFilter.Models;
using XFFilter.ViewModels;

namespace XFFilter
{
    public partial class MainPage : ContentPage
    {
        EmpManagementViewModel _myEmpManagementViewModel;
        string _eSalonID = "e000000001";

        private bool isRowEven;

        private void Cell_OnAppearing(object sender, EventArgs e)
        {
            if (this.isRowEven)
            {
                var viewCell = (ViewCell)sender;
                if (viewCell.View != null)
                {
                    viewCell.View.BackgroundColor = Color.FromHex("#7EB4C2");
                }
            }

            this.isRowEven = !this.isRowEven;
        }


        public MainPage()
        {
            InitializeComponent();
            Selector.SelectedIndexChanged += Selector_SelectedIndexChanged;
            
        }

        ObservableCollection<EmpManagement> newEmpManagement = new ObservableCollection<EmpManagement>();


        protected override void OnAppearing()
        {
            _myEmpManagementViewModel = new EmpManagementViewModel(_eSalonID);


            int selectedIndex = Selector.SelectedIndex;


            if (selectedIndex > -1)
            {
                SelectedIndexChanged(selectedIndex);
            }
            else
            {
                Selector.SelectedIndex = 0;
            }


        }

        private void SelectedIndexChanged(int selectedIndex)
        {
            if (selectedIndex > -1)
            {

                if (_myEmpManagementViewModel.EmpManagement.Count > 0)
                {
                    if (selectedIndex == 0)
                    {
                        _myEmpManagementViewModel.FilterReservationData("A");
                        BindingContext = _myEmpManagementViewModel;
                    }
                    else if (selectedIndex == 1)
                    {
                        _myEmpManagementViewModel.FilterReservationData("D");
                        BindingContext = _myEmpManagementViewModel;
                    }
                    else if (selectedIndex == 2)
                    {
                        _myEmpManagementViewModel.FilterReservationData("DS");
                        BindingContext = _myEmpManagementViewModel;
                    }
                    else
                    {
                        BindingContext = _myEmpManagementViewModel = new EmpManagementViewModel(_eSalonID);
                    }
                }

            }
            else
            {
                BindingContext = _myEmpManagementViewModel = new EmpManagementViewModel(_eSalonID);
            }


        }
        private void Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(Selector.SelectedIndex);


        }

        private async void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as EmpManagement;
            if (item != null)
            {
                //Navigate to DetailPage
                await Task.Delay(0);   
                //await Navigation.PushAsync(new EmpManagementDetailPage(item, _myEmpManagementViewModel) { Title = "Detail" });
            }


           ((ListView)sender).SelectedItem = null;
        }

        private void AddEmployeeRelation_Clicked(object sender, EventArgs e)
        {
            //Navigate to Add item Page 
            //await Navigation.PushAsync(new EmpManagementAddPage(_myEmpManagementViewModel));
        }
    }
}
