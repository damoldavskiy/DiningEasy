using System;
using System.Collections.Generic;
using System.Text;

namespace DiningEasy.Model
{
    public static class Manager
    {
        public static ICanteen CurrentCanteen;

        public static IStorage Storage { get; } = new StorageInbuilt();
    }
}
