using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemTemTeamBuilder.Models
{
    public class TemTem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double[] Stats { get; set; } = new double[8];
        public TemTrait[] Traits { get; set; }
        public List<TemTechnique> Techniques { get; set; }
        public int[] TrueStats { get; set; } = new int[7];
        public double[] Svs { get; set; } = new double[] { 50, 50, 50, 50, 50, 50, 50 };
        public double[] Tvs { get; set; } = new double[7];
        public double Level { get; set; } = 100;


    }
}
