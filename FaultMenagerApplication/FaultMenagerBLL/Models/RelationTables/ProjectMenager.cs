using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultMenager_Models.Models.RelationTables
{
    public class ProjectMenager
    {
        public int ProjectId { get; set; }

        public int MenagerId { get; set; }


        public Project Project { get; set; }

        public Menager Menager { get; set; }

        
    }
}
