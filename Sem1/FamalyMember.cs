using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1
    {
    internal class FamalyMember
        {
        internal int Age { get; init; }
        internal string Name { get; set; }
        internal string Surename { get; set; }
        internal Gender Gender { get; set; }
        internal FamalyMember Mother { get; set; }
        internal FamalyMember Father { get; set; }

        internal FamalyMember[] GetGrandMother()
            {
            return new FamalyMember[] { Mother.Mother, Father.Mother };
            }

        internal FamalyMember[] GetGrandFather()
            {
            return new FamalyMember[] { Mother.Father, Father.Father };
            }
        }

    internal enum Gender
        {
        male,
        female,
        }
    }
