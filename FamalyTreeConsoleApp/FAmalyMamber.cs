using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamalyTreeConsoleApp;

internal class FamalyMamber
    {
    internal int Age { get; set; }
    internal string FullName { get; set; }
    internal Gender Gender { get; set; }
    internal FamalyMamber Mother { get; set; }
    internal FamalyMamber Father { get; set; }

    internal FamalyMamber[] GetGrandFathers()
        {
        return new[] { Father.Father, Mother.Father };
        }

    internal FamalyMamber[] GetGrandMothers()
        {
        return new[] { Mother.Mother, Father.Mother };
        }

    }

internal enum Gender
    {
    male,
    female
    }


