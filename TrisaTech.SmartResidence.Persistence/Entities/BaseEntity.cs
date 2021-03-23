﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrisaTech.SmartResidence.Persistence.Entities
{
    public enum AuditActivtyType
    {
        INSERT,
        UPDATE,
        DELETE
    }
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public AuditActivtyType AuditActivty { get; set; } 
    }
}
