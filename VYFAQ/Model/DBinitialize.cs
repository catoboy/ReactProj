using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace VYFAQ.Model
{
    public class DBinitialize
    {
        public static void Initialize(IServiceScope serviceScope)
        {
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<Context>();
            dbContext.Database.EnsureCreated();
            if (!dbContext.QandA.Any())
            {
                var QA = new QA[]
                {
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "Nå"
                    },
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "Nå"
                    },
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "Nå"
                    },                    
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "Nå"
                    },                    
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "Nå"
                    }
                };

                foreach (var a in QA)
                {
                    dbContext.QandA.Add(a);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
