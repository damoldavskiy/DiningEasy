using System;
using System.Collections.Generic;
using System.Text;

namespace DiningEasy.Model
{
    public static class Manager
    {
        public static IStorage GetDefaultStorage()
        {
            return new StorageInbuilt();
        }
    }
}
