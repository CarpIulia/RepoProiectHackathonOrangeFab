using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistici.entities
{
    class Temperatura
    {
        public Temperatura(double minim,double maxim,DateTime data)
        {
            this.minim = minim;
            this.maxim = maxim;
            this.data = data;
        }
        public double minim { get; }
        public double maxim { get; }
        public  DateTime data { get; }
    }
}
