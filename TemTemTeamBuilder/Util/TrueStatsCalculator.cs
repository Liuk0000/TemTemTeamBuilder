using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemTemTeamBuilder.Models;

namespace TemTemTeamBuilder.Util
{
    public class TrueStatsCalculator
    {
        public static int[] CalculateTrueStats(TemTem tem)
        {
            return new int[]
                    {
                        Convert.ToInt32(Math.Floor(15 + tem.Level + ((tem.Svs[0] * tem.Stats[0] * tem.Level) / 20000) + ((tem.Level * ((tem.Tvs[0] / 5) + tem.Svs[0] + (1.5f * tem.Stats[0]))) / 80))),
                        Convert.ToInt32(Math.Floor((tem.Stats[1] / 4) + (Math.Pow(tem.Level, 0.35f) * 6) + ((tem.Svs[1] * tem.Stats[1] * tem.Level) / 20000) + ((tem.Tvs[1]* tem.Level * tem.Stats[1]) / 30000))),
                        Convert.ToInt32(Math.Floor(10 + ((tem.Svs[2] * tem.Stats[2] * tem.Level) / 25000) + ((tem.Level * ((tem.Tvs[2] / 5) + tem.Svs[2] + (1.5f * tem.Stats[2]))) / 100))),
                        Convert.ToInt32(Math.Floor(10 + ((tem.Svs[3] * tem.Stats[3] * tem.Level) / 25000) + ((tem.Level * ((tem.Tvs[3] / 5) + tem.Svs[3] + (1.5f * tem.Stats[3]))) / 100))),
                        Convert.ToInt32(Math.Floor(10 + ((tem.Svs[4] * tem.Stats[4] * tem.Level) / 25000) + ((tem.Level * ((tem.Tvs[4] / 5) + tem.Svs[4] + (1.5f * tem.Stats[4]))) / 100))),
                        Convert.ToInt32(Math.Floor(10 + ((tem.Svs[5] * tem.Stats[5] * tem.Level) / 25000) + ((tem.Level * ((tem.Tvs[5] / 5) + tem.Svs[5] + (1.5f * tem.Stats[5]))) / 100))),
                        Convert.ToInt32(Math.Floor(10 + ((tem.Svs[6] * tem.Stats[6] * tem.Level) / 25000) + ((tem.Level * ((tem.Tvs[6] / 5) + tem.Svs[6] + (1.5f * tem.Stats[6]))) / 100)))
                    };
        }
    }
}
