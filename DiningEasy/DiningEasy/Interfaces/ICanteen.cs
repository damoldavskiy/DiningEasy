﻿using System.Collections.Generic;

namespace DiningEasy
{
    public interface ICanteen
    {
        string Name { get; set; }

        string Info { get; set; }

        IEnumerable<ICategory> Categories { get; set; }
    }
}
