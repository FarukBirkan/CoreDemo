using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContextId { get; set; }
        public string ContextUserName { get; set; }
        public string ContextMail { get; set; }
        public string ContextSubject { get; set; }
        public string ContextMessage { get; set; }
        public DateTime ContextDate { get; set; }
        public bool  ContextStatus { get; set; }
    }
}
