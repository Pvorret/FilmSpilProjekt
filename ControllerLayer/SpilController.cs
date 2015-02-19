using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Film.Database;

namespace ControllerLayer
{
    public class SpilController
    {

        public string GetTest()
        {
            return SpilDB.GetTest();

        }
    }
}
