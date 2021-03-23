using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrisaTech.SmartResidence.Persistence.Entities
{
    public enum ProgramPeriod
    {
        None,
        Daily,
        Weekly,
        BiWeekly,
        Monthly
    }
    public class ResidentProgram : BaseEntity
    {
        [Required]
        public int Year { get; set; }
        [Required]
        [StringLength(150)]
        public string ProgramSubject { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        public string Desc { get; set; }
        public decimal Cost { get; set; }
        public ProgramPeriod ProgramPeriod { get; set; }
        public Guid PersonInChargeId { get; set; }
        public virtual Resident PersonInCharge { get; set; }
    }
}
