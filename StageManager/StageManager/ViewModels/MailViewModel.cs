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
        public String To { get; set; }
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
            Mailer.SendNew(To, Message, Subject, new ListDictionary());
        }
    }
}
