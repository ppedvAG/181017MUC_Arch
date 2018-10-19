using HalloMVVM.Helpers;
using HalloMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HalloMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            GetPersonenCommand = new RelayCommand(GetPersonen);
        }

        private void GetPersonen()
        {
            Personenliste = new PersonenService().GetPersonen();
        }

        private List<Person> personenliste;
        public List<Person> Personenliste
        {
            //get { return personenliste; }
            get => personenliste;
            set => SetProperty(ref personenliste, value);
        }
        public RelayCommand GetPersonenCommand { get; set; }
    }
}
