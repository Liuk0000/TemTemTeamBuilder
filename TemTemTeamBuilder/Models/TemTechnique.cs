using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemTemTeamBuilder.Models
{
    public class TemTechnique
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BasePower { get; set; }
        public TechniqueType Type { get; set; }
        public int StaminaCost { get; set; }
        public TechniquePriority Priority { get; set; }
        public int Hold { get; set; }
        public TechniqueTargeting Targeting { get; set; }
        public Boolean HasSynergy { get; set; }
    }
}
