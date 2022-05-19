using FaultMenager_Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultMenager_Models.Models
{
    public class Fault
    {
        public int FaultId { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }


        public string Desription { get; set; }

        public Status Status { get; set; } 

        public Category Category { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public int SubcontractorId { get; set; }

        public SubcontractorFirm SubcontractorFirm { get; set; }

        // List of comments

        // List of fotos

        //


    }
}
