using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.DAL.Entities
{
    public class Dialog : BaseEntity
    {
        public List<Message> Messages { get; set; }
    }
}
