using ProcessFile.API.Job.http;
using S22.Imap;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;

namespace ProcessFile.API.Job.Services
{
    public class JobReadingEmailService
    {
        public static async void Reading(string url)
        {
            Http http = new Http();
            var jobId = await http.PostJob(url);

            using (ImapClient client = new ImapClient("outlook.office365.com", 993, "beneficiofaber@outlook.com", "Faber@123", AuthMethod.Login, true))
            {
                IEnumerable<uint> uids = client.Search(SearchCondition.Unseen());
                IEnumerable<MailMessage> messages = client.GetMessages(uids);

                foreach (MailMessage item in messages)
                {
                    Console.WriteLine("\t Asunto: " + item.Subject);

                    foreach (Attachment attachment in item.Attachments)
                    {
                        byte[] allBytes = new byte[attachment.ContentStream.Length];
                        int bytesRead = attachment.ContentStream.Read(allBytes, 0, (int)attachment.ContentStream.Length);

                        string[] nameFile = attachment.Name.Split(".");
                        string fileName = nameFile[0] + DateTime.Now.ToString("ddMMyyyyhhmmss") + "." + nameFile[1];

                        string destinationFile = Directory.GetCurrentDirectory() + fileName;

                        BinaryWriter writer = new BinaryWriter(new FileStream(destinationFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None));
                        writer.Write(allBytes);
                        writer.Close();

                        await Http.PostFile(url, fileName, item.Subject);
                    }
                }
            }   

            await Http.UpdateJob(url, jobId);
        }
    }
}
