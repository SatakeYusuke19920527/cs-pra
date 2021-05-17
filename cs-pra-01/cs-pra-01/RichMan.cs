using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace cs_pra_01
{
    class RichMan : Person
    {
        public int money = 0;

        public new int MyProperty { get; set; }
    }
}
