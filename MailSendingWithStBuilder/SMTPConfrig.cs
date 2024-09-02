using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSendSystem
{
    public class SMTPConfrig
    {
        public string Host { get; set; }

        public int Port { get; set; }

        public bool EnableSsl { get; set; }

        public string FromEmail { get; set; }

        public string FromPassword { get; set; }

    }
}
