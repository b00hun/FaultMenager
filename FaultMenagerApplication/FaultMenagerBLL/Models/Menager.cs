using FaultMenager_Models.Models.RelationTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultMenager_Models.Models
{
    public class Menager
    {
        public int MenagerId { get; set; }

        public string MenagerName { get; set; }

        public string MenagerSurname { get; set; }

        public int MenagerPhoneNumber    { get; set; }

        public string MenagerMail { get; set; }

        public virtual ICollection<ProjectMenager> ProjectMenagers { get; set; }
    }
}
