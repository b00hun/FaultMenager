using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultMenager_Models.Models
{
    public class SubcontractorFirm
    {
        public int SubcontractorFirmId { get; set; }

        public string SubcontractorName { get; set; }

        public List<Fault> Faults { get; set; }

        public List<SubcontractorWorker> Workers { get; set; }

    }
}
