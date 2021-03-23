﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrisaTech.SmartResidence.Persistence.Entities
{
    public enum HouseType
    {
        Residence,
        Business,
        EmptyLand,
    }
    public enum HouseStatus
    {
        Occupied,
        Empty,
        Rented
    }
    public class House : BaseEntity
    {
        [Required]
        public int Order { get; set; }
        [Required]
        [StringLength(StringLengthConstant.StringIdentityLength)]
        public string Number { get; set; }
        public HouseType Type { get; set; }
        public HouseStatus Status { get; set; }
        [Required]
        [ForeignKey(nameof(Resident))]
        public Guid OwnerId { get; set; }
        [Required]
        [ForeignKey(nameof(Resident))]
        public Guid OccupantId { get; set; }
        public virtual Resident Owner { get; set; }
        public virtual Resident Occupant { get; set; }
        public virtual ICollection<Resident> ResidentHistory { get; set; }
    }
}
