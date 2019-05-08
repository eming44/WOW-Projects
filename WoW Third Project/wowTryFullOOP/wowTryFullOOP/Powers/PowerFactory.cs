using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class PowerFactory
    {
        public static IPower CreateRagePower()
        {
            return new RagePower();
        }
        public static IPower CreateManaPower()
        {
            return new ManaPower(200);
        }
    }
}
