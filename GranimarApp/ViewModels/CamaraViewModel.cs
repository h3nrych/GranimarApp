using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCrud.ViewModels
{
    public class PhotoViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<PhotoItem> Photos { get; set; }

        public PhotoViewModel()
        {
            Photos = new ObservableCollection<PhotoItem>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class PhotoItem
    {
        public string PhotoPath { get; set; }
        public string Description { get; set; }
    }
}
