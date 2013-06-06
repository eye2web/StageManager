using StageManager.Services;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManager.ViewModels
{
    class MailViewModel
    {
        private String to;
        public String To
        {
            get
            {
                return to;
            }
            set
            {
                char[] c = value.ToCharArray();
                String s="";
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == '\n' || c[i] == ' ')
                    {
                        c[i] = ',';
                    }
                    if (c[i] != '\r')
                    {
                        s += c[i];
                    }
                }
                to = s;
            }
        }

        public String Message { get; set; }
        public String Subject { get; set; }

        public MailViewModel()
        {
            Message = "Beste student,\n\n" +
                "Met deze mail vragen wij vriendelijk om je gegevens in te vullen in dit web formulier\n" +
                "%webkey%\n\n\n" +
                "Met vriendelijke groeten,\n" +
                "Katinka Janssen\n" +
                "Stagecoördinator AI&I\n" +
                "Avans Hogeschool 's-Hertogenbosch";
        }
        public void Send()
        {
            char[] c = { ',', ';', ' ', ':' };
            String[] to = To.Split(c);
            for (int i = 0; i < to.Length; i++)
            {
                Mailer.SendNew(to[i].Trim(), Message, Subject, new ListDictionary());
            }
        }
    }
}
