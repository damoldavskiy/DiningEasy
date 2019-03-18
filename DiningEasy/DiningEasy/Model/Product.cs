using System.ComponentModel;

namespace DiningEasy.Model
{
    public class Product : IProduct, INotifyPropertyChanged
    {
        string name;
        Category category;
        string description;
        string ingridients;
        int weight;
        int cost;

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

        public ICategory Category
        {
            get
            {
                return category;
            }
            set
            {
                if (category != value)
                {
                    category = (Category)value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public string Ingridients
        {
            get
            {
                return ingridients;
            }
            set
            {
                if (ingridients != value)
                {
                    ingridients = value;
                    OnPropertyChanged(nameof(Ingridients));
                }
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (weight != value)
                {
                    weight = value;
                    OnPropertyChanged(nameof(Weight));
                }
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (cost != value)
                {
                    cost = value;
                    OnPropertyChanged(nameof(Cost));
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
