using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2DB
{
    internal class Addedbook
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string TopicName { get; set; }
        public string AuthorName { get; set; }
        public string Descriptions { get; set; }

        public Addedbook()
        {

        }
        public Addedbook(string BookID, string BookName, string TopicName, string AuthorName, string Descriptions)
        {
            this.BookID = BookID;
            this.BookName = BookName;
            this.TopicName = TopicName;
            this.AuthorName = AuthorName;
            this.Descriptions = Descriptions;
        }
    }
}
