using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_4.CodeAnalyser
{
    class NamespaceInfo
    {
        public string Name { get; }
        public ClassInfo ClassName { get; }

        public NamespaceInfo(string name, ClassInfo className)
        {
            Name = name;
            ClassName = className;
        }
    }
}
