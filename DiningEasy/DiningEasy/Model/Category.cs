﻿using System.Collections.Generic;
using System.ComponentModel;

namespace DiningEasy.Model
{
    public class Category : ICategory, INotifyPropertyChanged
    {
        string name;
        string path;
        IEnumerable<IProduct> products;

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
        /// Доступные продукты
        /// </summary>
        public IEnumerable<IProduct> Products
        {
            get
            {
                return products;
            }
            set
            {
                if (products != value)
                {
                    products = value;
                    OnPropertyChanged(nameof(Product));
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
