using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.DAL.Entities
{
    public class Message : BaseEntity
    {
        public string SenderId { get; set; }
        public string Text { get; set; }
        public DateTimeOffset DateSent { get; set; }
        public int DialogId { get; set; }
        public Dialog Dialog { get; set; }
    }
}
