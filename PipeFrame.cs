using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_4
{
    class PipeFrame
    {
        public string path;
        public string code;

        public PipeFrame(string path)
        {
            this.path = path;
        }

        public PipeFrame(string path, string code)
        {
            this.path = path;
            this.code = code;
        }
    }
}
