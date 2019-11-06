using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MT123123123.Models
{
    public class Message
    {
        public virtual int Id { get; set; }

        [Required]
        public virtual String Name { get; set; }
        [Required]
        public virtual String Msg { get; set; }

        public virtual DateTime PostedAt { get; set; } = DateTime.Now;
    }
}
