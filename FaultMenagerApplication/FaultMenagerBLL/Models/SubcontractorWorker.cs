using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultMenager_Models.Models
{
    public class SubcontractorWorker
    {
        //SubcontractorMenager
        public int SubcontractorId { get; set; }

        public string Name { get; set; }

        public int WorkerPhone { get; set; }
        public string Email { get; set; }

        public int SubcotractorFirmId { get; set; }
       
        public SubcontractorFirm SubcontractorFirm { get; set; } 

    }
}
