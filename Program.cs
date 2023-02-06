using gts;
using HslCommunication.Profinet.Siemens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 反射与特性
{
    class Program
    {
        static void Main(string[] args)
        {
            mc mc1 = new mc();
            mc.GT_AxisOn(1);
            mc.GT_AlarmOn(1);
            SiemensS7Net simensS7Net = new SiemensS7Net(SiemensPLCS.S1500);

        }
    }
}
