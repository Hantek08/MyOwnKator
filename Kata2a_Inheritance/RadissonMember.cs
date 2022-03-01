using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2a_Inheritance
{
    internal class RadissonMember : Member, IRadissonMember
    {
        public override string[] Benefits { get; set; }
    }
}
