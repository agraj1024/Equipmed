using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class AdminRequestBE:BaseRequest
    {
        public string AdminName{ get; set; }
        public string AdminPassword { get; set; }

    }
}
