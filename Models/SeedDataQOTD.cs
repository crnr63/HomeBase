using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HomeBase.Models
{
    public static class SeedDataQOTD
    {
        public static void InitializeQOTD(IServiceProvider serviceProvider)
        {
            using (var context = new QOTDContext (
                serviceProvider.GetRequiredService<DbContextOptions<QOTDContext>>()))
            {
                // Look for any movies.
             if (context.QOTD.Any())
                {
                    return;   // DB has been seeded
                }
                
                  context.QOTD.AddRange(
                     
                     new QOTD
                     {
                        Question = "How many Times did Enzo wear a dress in High School?",
                        QuestionAuthor= "Charles",
                        QuestionDate=DateTime.Parse("2018-3-11"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Hardwood Floors or Carpet?",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-13"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Waffles or Pancakes?",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-14"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "French Fries or Sweet Potato Fries ",
                        QuestionAuthor= "Charles",
                        QuestionDate=DateTime.Parse("2018-3-15"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Where Does Everyone Live Now",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-15"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Mr Seignot, Mme Forest or Mme Carrenard",
                        QuestionAuthor= "Etienne",
                        QuestionDate=DateTime.Parse("2018-3-15"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Cats or Dogs?",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-19"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Picasso or Van Gogh?",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-20"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Yay Snow? or Fuck Snow?",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-21"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Best Birth Year: 1988,1989 or 1990",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-22"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Cruise, Beach or Lake House, or Ski Chalet",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-23"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Apples or Oranges?",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-26"),
                        Theme="",
                     },                     
                     new QOTD
                     {
                        Question = "Least Favorite Applications: Job, Housing, School",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-27"),
                        Theme="",
                     },                     
                     new QOTD
                     {
                        Question = "Bar Soap or Body Wash?",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-28"),
                        Theme="",
                     },
                     new QOTD
                     {
                        Question = "Snap Chat or Instagram Video",
                        QuestionAuthor= "Karen",
                        QuestionDate=DateTime.Parse("2018-3-29"),
                        Theme="",
                     },
                    new QOTD
                     {
                        Question = "No limitations , get travel anywhere in the world, where are you going?",
                        QuestionAuthor= "Khalil",
                        QuestionDate=DateTime.Parse("2018-3-30"),
                        Theme="Friday Leisure Edition",
                     }
                     

          
                     
                );
           
                context.SaveChanges();
            }
        }
    }
}



