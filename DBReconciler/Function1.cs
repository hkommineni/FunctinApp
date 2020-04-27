using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DBReconciler
{
    public static class Function1
    {
        [FunctionName("ReconcileTransactions")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function version 1.0.0 executed at: {DateTime.Now}");
        }
    }
}
