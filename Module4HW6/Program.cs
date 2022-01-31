using System;
using System.Threading.Tasks;
using Module4HW6.Helper;

namespace Module4HW6
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var sampleContextFactory = new SampleContextFactory();
            await using (var dbContext = sampleContextFactory.CreateDbContext(args))
            {
                var transactionHelper = new TransactionHelper(dbContext);
                var dbDataInitializer = new DbDataInitializer(dbContext, transactionHelper);
                var requests = new Requests(dbContext, transactionHelper);
                await dbDataInitializer.InitializeAsync();
                await requests.FirstRequestAsync();
                await requests.SecondRequestAsync();
                await requests.ThirdRequestAsync();
            }

            Console.ReadLine();
        }
    }
}
