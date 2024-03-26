using System;
using Avalonia.Collections;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using AvaloniaApplication3.Models;

namespace AvaloniaApplication3.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    { 
        public ObservableCollection <Place> Names { get; } = new ObservableCollection <Place>();
    
        private string _name = "";

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

       
    }
}

