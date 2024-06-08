using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeConsoleApp;

internal class FamilyMamber
    {
    internal int Age { get; set; }
    internal string Name { get; set; }
    internal string Surname { get; set; }
    internal Gender Gender { get; set; }
    internal FamilyMamber Mother { get; set; }
    internal FamilyMamber Father { get; set; }
    internal bool Married { get; set; } = false;
    internal bool children { get; set; } = false;
    internal FamilyMamber Husband { get; set; }
    internal FamilyMamber Wife { get; set; }

    internal FamilyMamber?[] GetGrandFathers()
        {
        return new[] { Father?.Father, Mother?.Father };
        }

    internal FamilyMamber?[] GetGrandMothers()
        {
        return new[] { Mother?.Mother, Father?.Mother };
        }

    }




