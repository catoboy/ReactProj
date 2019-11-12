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
                        answer = "På vy.no får du kjøpt de fleste billetter ved å bruke reiseplanleggeren. Reiser du " +
                                 "på Østlandet og i Hordaland, kan du på visse strekninger kjøpe 7 og 30 dagers " +
                                 "elektronisk periodebillett på vy.no. Reisende i Rogaland kan kjøpe elektronisk " +
                                 "periodebillett i Vy-appen eller periodebillett på reisekort hos Kolumbus. " +
                                 "En periodebillett med setereservasjon kan kun kjøpes i Vy-appen.",
                        time = "12.11.2019 15:00",
                        rating = 36
                    },
                    new QA()
                    {
                        question = "Hvordan får jeg plass i Komfort?",
                        answer = "Komfort selges som et tillegg til billetter på lange regiontog og koster 100 kr" +
                                 " per person uansett hvor langt du reiser. Du kan velge Komfort når du kjøper " +
                                 "billetten på vy.no eller i appen. Du kan også kjøpe Komfort om bord av " +
                                 "konduktøren, hvis det er ledig plass.",
                        time = "12.11.2019 17:00",
                        rating = 12
                    },
                    new QA()
                    {
                        question = "Hvordan kan jeg endre eller refundere billetten?",
                        answer = "Hvis du har enkeltbillett og vil endre eller refundere billetten din, så kan " +
                                 "du gjøre det gratis frem til 24 timer før avgang. Ved mindre enn 24 timer før" +
                                 "avgang må du betale et gebyr. Miniprisbilletter kan ikke endres eller refunderes.",
                        time = "05.11.2019 11:00",
                        rating = 45,
                    },                    
                    new QA()
                    {
                        question = "Kan jeg få erstatning for merkostnader ved forsinkelse?",
                        answer = "I situasjoner der du må ta i bruk alternativ transport eller får andre utgifter i " +
                                 "forbindelse med forsinkelse eller kansellering av tog, kan du få refundert hele " +
                                 "eller deler av utleggene. Dette må gjøres skriftlig med vedlagt dokumentasjon " +
                                 "innen tre måneder etter hendelsen.",
                        time = "12.10.2019 09:00",
                        rating = 78
                    },                    
                    new QA()
                    {
                        question = "Kan jeg ha med pulk, rattkjelke eller sparkstøtting?",
                        answer = "Pulk, rattkjelke og sparkstøtting er bagasje som på grunn av volum, form og " +
                                 "størrelse vanskelig kan plasseres i bagasjehyller om bord i toget. Derfor må du " +
                                 "bestille plass på samme måte som for sykkel. Du må betale sykkelbillett, og du " +
                                 "er selv ansvarlig for inn- og utlasting.",
                        time = "01.05.2019 08:00",
                        rating = 5
                    },                    
                    
                    new QA()
                    {
                        question = "Kan jeg ha med kontrabass?",
                        answer = "Skal du reise langt med regiontog kan du bestille plass til kontrabassen i godsrom" +
                                 "dersom det er ledig. Ta kontakt med kundeservice i god tid før reisen for" +
                                 "å bestille plass På korte regiontog og lokaltog kan du ta med kontrabassen " +
                                 "dersom det er plass og den kan tas med på en sikker måte.",
                        time = "09.05.2019 18:00",
                        rating = 96
                    },
                    new QA()
                    {
                    question = "Hvilken mat kan jeg kjøpe om bord?",
                    answer = "Hvis toget ditt har kafé, kan vi tilby smakfulle matopplevelser om bord. Sammen med" +
                             " Jostein Medhus, landslagskokk fra Kulinarisk Akademi, har vi utviklet en meny basert" +
                             "på norske smaker og lokale råvarer i sesong. Vi er stolte av å presentere en rekke " +
                             "produsenter som brenner for god smak og egenart. Resultatet er en variert meny med " +
                             "store, små, varme og kalde norske favoritter. Vi har også en barnemeny. På nattoget " +
                             "tilbyr vi en enklere kveldsmeny. Kafeen er åpen under hele turen.",
                    time = "24.05.2019 16:00",
                    rating = 65
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
