﻿using StageManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private static WStored stored;
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
                smtp.Credentials = new NetworkCredential("stagemanager.min08sog@gmail.com", "stagemanager");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                stored = new WStored();

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
            char[] c = { ',', ';', ':' };
            String[] To = to.Split(c);
            for (int i = 0; i < To.Length; i++)
            {
                MailDefinition m = new MailDefinition();
                if (!replacements.Contains("\n"))
                {
                    replacements.Add("\n", "<br/>");
                }
                m.IsBodyHtml = true;
                m.Subject = Subject;
                m.From = "min08.stagemanager@gmail.com";
                try
                {
                    mails.AddLast(m.CreateMailMessage(To[i], replacements, body, new System.Web.UI.Control()));
                }
                catch (Exception)//TODO
                { };
            }
            if (!isSending)
            {
                next(null, null);
            }
        }

        public static void SendNew(String to, String body, String Subject, IDictionary replacements = null)
        {
            init();
            if (replacements.Contains("%webkey%"))
            {
                replacements.Remove("%webkey%");
            }
            String webkey;
            webkey = stored.NewWebkey(to);
            WWebkey key = new WWebkey(new webkeysets() { ConnectionKey = webkey, Status="actief" });
            key.add(key.getSet());

            System.Reflection.Assembly thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            string path = thisExe.Location;
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            string folderName = dirinfo.Parent.FullName;
            path = folderName + "\\Config.txt";
            Uri uri = new Uri(path);
            String s = File.ReadAllText(uri.AbsolutePath);
            String[] split = { "server: " };
            String[] server = s.Split(split, StringSplitOptions.RemoveEmptyEntries);
            webkey = server[0] + webkey;
            replacements.Add("%webkey%", "<a href='" + webkey + "'>" + webkey + "</a>");
            Send(to, body, Subject, replacements);
        }
    }
}