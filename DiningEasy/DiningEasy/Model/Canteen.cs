using System.ComponentModel;

namespace DiningEasy.Model
{
    public class Canteen : ICanteen, INotifyPropertyChanged
    {
        string name;
        string info;

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
                    OnPropertyChanged(nameof(info));
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
