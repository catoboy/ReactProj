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
                        time = "12.11.2019 15:00"
                    },
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "12.11.2019 17:00"
                    },
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "05.11.2019 11:00"
                    },                    
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "12.10.2019 09:00"
                    },                    
                    new QA()
                    {
                        question = "Hvor kjøper jeg billett?",
                        answer = "Spør Cato",
                        time = "01.05.2019 08:00"
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
