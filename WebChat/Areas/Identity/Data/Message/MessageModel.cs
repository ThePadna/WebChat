using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Models
{
    public class MessageModel
    {

        public MessageModel()
        {

        }

        [Key]
        public string Sender { get; set; }
        public DateTime Date { get; set; }
        public string Contents { get; set; }
    }
}
