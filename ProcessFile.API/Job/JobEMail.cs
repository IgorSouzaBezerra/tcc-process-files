using ProcessFile.API.Job.http;
using ProcessFile.API.Job.Services;
using System;

namespace ProcessFile.API.Job
{
    public class JobEMail
    {
        public static void Execute()
        {
            Console.WriteLine("[JOB] Executando - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            JobReadingEmailService.Reading();
            Console.WriteLine("[JOB] Finalizando - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }
    }
}
