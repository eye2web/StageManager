using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace StageManager.Services
{
    class Mailer
    {
        private static LinkedList<MailMessage> mails;
        private static SmtpClient smtp = new SmtpClient();
        private static bool _init;
        private static bool isSending;

        public static bool IsSending
        {
            get { return Mailer.isSending; }
            set { Mailer.isSending = value; }
        }

        private static void init()
        {
            if (!_init)
            {
                mails = new LinkedList<MailMessage>();
                smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.SendCompleted += next;
                smtp.Credentials = new NetworkCredential("min08.stagemanager@gmail.com", "Stagemanager");

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                isSending = false;
                _init = true;
            }
        }

        private static void next(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try
            {
                if (mails.Count > 0)
                {
                    smtp.SendAsync(mails.Last.Value, null);
                    isSending = true;
                    mails.RemoveLast();
                }
                else
                {
                    isSending = false;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }

        public static void Send(String to, String body, String Subject, IDictionary replacements = null)
        {
            init();
            char[] c = { ',', ';', ' ', ':', '\t' };
            String[] To = to.Split(c);
            for (int i = 0; i < to.Length; i++)
            {
                MailDefinition m = new MailDefinition();
                if (!replacements.Contains("\n"))
                {
                    replacements.Add("\n", "<br/>");
                }
                m.IsBodyHtml = true;
                m.Subject = Subject;
                m.From = "min08.stagemanager@gmail.com";
                mails.AddLast(m.CreateMailMessage(to, replacements, body, new System.Web.UI.Control()));
            }
            if (!isSending)
            {
                next(null, null);
            }
        }
    }
}
