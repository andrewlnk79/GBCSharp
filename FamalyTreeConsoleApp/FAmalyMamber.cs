using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamalyTreeConsoleApp
    {
    internal class FAmalyMamber
        {
        internal int Age { get; set; }
        internal string FullName { get; set; }
        internal Gender Gender { get; set; }
        }
    internal enum Gender
        {
        male,
        female
        }
    }
