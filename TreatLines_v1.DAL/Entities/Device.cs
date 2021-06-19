using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreatLines_v1.DAL.Entities
{
    public class Device : BaseEntity
    {
        public string Name { get; set; }
    }
}
