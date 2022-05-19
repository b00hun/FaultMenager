using FaultMenager_Models.Models.RelationTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultMenager_Models.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string ProjectAdress { get; set; }

        public virtual ICollection<ProjectMenager> ProjectMenagers { get; set; }
    }
}
