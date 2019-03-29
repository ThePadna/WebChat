using System;

namespace WebChat.Models
{
    public class MessageModel
    {

        public int Id { get; set; }
        public string Sender { get; set; }
        public DateTime Date { get; set; }
        public string Contents { get; set; }

        public MessageModel() { }
        public MessageModel(string sender, string contents, DateTime date)
        {
            this.Sender = sender;
            this.Contents = contents;
            this.Date = date;
        }
    }
}
