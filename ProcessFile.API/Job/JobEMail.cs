using ProcessFile.API.Job.Services;
using System;

namespace ProcessFile.API.Job
{
    public class JobEMail
    {
        public static void Execute(string url)
        {
            Console.WriteLine("[JOB] Executando - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + url);
            JobReadingEmailService.Reading(url);
            Console.WriteLine("[JOB] Finalizando - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + url);
        }
    }
}
