using System.Collections.Generic;
using System.ComponentModel;

namespace DiningEasy.Model
{
    public class Canteen : ICanteen, INotifyPropertyChanged
    {
        string name;
        string info;
        IEnumerable<ICategory> categories;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                if (info != value)
                {
                    info = value;
                    OnPropertyChanged(nameof(Info));
                }
            }
        }

        public IEnumerable<ICategory> Categories
        {
            get
            {
                return categories;
            }
            set
            {
                if (categories != value)
                {
                    categories = value;
                    OnPropertyChanged(nameof(Categories));
                }
            }
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion
    }
}
