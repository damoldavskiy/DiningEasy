using System.ComponentModel;

namespace DiningEasy.Model
{
    public class Product : IProduct, INotifyPropertyChanged
    {
        string path;
        string name;
        string description;
        string ingridients;
        int weight;
        int cost;

        /// <summary>
        /// Путь до изображения
        /// </summary>
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                if (path != value)
                {
                    path = value;
                    OnPropertyChanged(nameof(Path));
                }
            }
        }

        /// <summary>
        /// Название
        /// </summary>
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

        /// <summary>
        /// Описание
        /// </summary>
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

        /// <summary>
        /// Ингридиенты
        /// </summary>
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

        /// <summary>
        /// Вес (в граммах)
        /// </summary>
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

        /// <summary>
        /// Стоимость
        /// </summary>
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
