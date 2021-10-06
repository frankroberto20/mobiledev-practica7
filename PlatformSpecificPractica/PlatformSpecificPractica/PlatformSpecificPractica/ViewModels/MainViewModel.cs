using PlatformSpecificPractica.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace PlatformSpecificPractica.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            GroupedEmployees.Add(new Employee{ID = 1, Name="John", Salary = 10000});
            GroupedEmployees.Add(new Employee{ID = 2, Name="Michael", Salary = 20000});
            GroupedEmployees.Add(new Employee{ID = 3, Name="Susan", Salary = 15000});
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Employee> GroupedEmployees {get;} = new ObservableCollection<Employee>();
    }
}
