using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_4.CodeAnalyser
{
    class ClassInfo
    {
        public string Name { get; }
        public List<MethodInfo> Methods { get; }

        public ClassInfo(string name, IEnumerable<MethodInfo> methods)
        {
            Name = name;
            Methods = new List<MethodInfo>(methods);
        }
    }
}
