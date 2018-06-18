using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HomeBase.Models
{
    public static class SeedAnswers

    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QOTDContext (
                serviceProvider.GetRequiredService<DbContextOptions<QOTDContext>>()))
            {
                // Look for any movies.
                if (context.QOTDAnswer.Any())
                {
                    return;   // DB has been seeded
                }

                context.QOTDAnswer.AddRange(
                     
                     new QOTDAnswer
                     {
                        Question ="How many Times did Enzo wear a dress in High School?"   ,    
                        QuestionID =1  ,      
                        Author ="23"  ,
                        Answer="2",
                     },

                      new QOTDAnswer
                     {
                        Question ="How many Times did Enzo wear a dress in High School?"   ,    
                        QuestionID =1  ,      
                        Author ="1"  ,
                        Answer="3",
                     },
                      new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="13"  ,
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="24"  ,
                        Answer="Hardwood",
                     },
                      new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="15"  ,
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="19"  ,
                        Answer="Hardwood",
                     },
                      new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="20"  ,
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="6"  ,
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="5"  ,
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="25"  ,
                        Answer="Laminate or Hardwood",
                     },
                      new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="27"  ,
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="1"  ,
                        Answer="Hardwood",
                     },
              
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="15"  ,
                        Answer="Belgian Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="5"  ,
                        Answer="Pancakes",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="12"  ,
                        Answer="Panffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="13"  ,
                        Answer="Belgian Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="19"  ,
                        Answer="Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="9"  ,
                        Answer="Belgian Waffles with Tienen Suga",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="18"  ,
                        Answer="Banana Pancakes",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="22"  ,
                        Answer="Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="24"  ,
                        Answer="Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="11"  ,
                        Answer="Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="1"  ,
                        Answer="Pancakes",
   
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="22"  ,
                        Answer="Sweet Potato Fries",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="19"  ,
                        Answer="French Fries",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="27"  ,
                        Answer="Sweet Potato Fries",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="26"  ,
                        Answer="Carnote",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="24"  ,
                        Answer="French Fries with Mayonnaise and Ketchup",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="13"  ,
                        Answer="Baked Potato",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="10"  ,
                        Answer="Sweet Potato Fries",
                     },  
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="16"  ,
                        Answer="French Fries",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="11"  ,
                        Answer="Get you a girl who can do both",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="18"  ,
                        Answer="Sweet Potato Fries",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="6"  ,
                        Answer="Truffle Fries",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="1"  ,
                        Answer="French Fries",
                     },                       


                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="1"  ,
                        Answer="D.C",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="16"  ,
                        Answer="Miami",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="27"  ,
                        Answer="Paris",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="6"  ,
                        Answer="Miami",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="11"  ,
                        Answer="Brooklyn, China, Australia",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="21"  ,
                        Answer="Miami",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="13"  ,
                        Answer="Paris",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="12 "  ,
                        Answer="Paris and Ireland",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="19"  ,
                        Answer="Melbourne, Florida",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="7"  ,
                        Answer="Tahiti",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="15"  ,
                        Answer="Montreal",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="14"  ,
                        Answer="Boston",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="24"  ,
                        Answer="Lausanne",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="10"  ,
                        Answer="Atlanta",
                     }, 
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="21"  ,
                        Answer="Seignot",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="1"  ,
                        Answer="All Three",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="13"  ,
                        Answer="Carrenard",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="6"  ,
                        Answer="Seignot",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="19"  ,
                        Answer="Forrest",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="18"  ,
                        Answer="Carrenard",
                     },
                    new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="24"  ,
                        Answer="Seignot",
                     },


                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="24"  ,
                        Answer="Dogs, cats are assholes",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="21"  ,
                        Answer="All pets except birds",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="1"  ,
                        Answer="Cats",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="18"  ,
                        Answer="Dogs",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="8"  ,
                        Answer="Dogs",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="12"  ,
                        Answer="Chiats",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="25"  ,
                        Answer="Dogs",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="5"  ,
                        Answer="Dogs",
                     },
            

                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="9"  ,
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="18"  ,
                        Answer="Both",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="17"  ,
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="1"  ,
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="5"  ,
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="8"  ,
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="11"  ,
                        Answer="Both",
                     },

                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="5"  ,
                        Answer="Fuck Snow except first snowfall",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="18"  ,
                        Answer="Yay Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="1"  ,
                        Answer="Fuck Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="13"  ,
                        Answer="Yay Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="15"  ,
                        Answer="Fuck Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="8"  ,
                        Answer="Yay Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="9"  ,
                        Answer="F Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="7"  ,
                        Answer="No to Snow, also the weather in Tahiti is great",
                     },

                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="4"  ,
                        Answer="88",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="9"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="1"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="13"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="20"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="15"  ,
                        Answer="90",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="8"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="21"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="17"  ,
                        Answer="88",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="24"  ,
                        Answer="88",
                     },

                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="1"  ,
                        Answer="Beach House",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="21"  ,
                        Answer="Beach House or Mountain Cabin",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="22"  ,
                        Answer=" Beach/Lake House",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="18"  ,
                        Answer="Beach or Lake House if it doesn't look like a scary movie serial killer house",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="9"  ,
                        Answer="Beach House on a Mountain",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="24"  ,
                        Answer="Mountain Chalet",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="5"  ,
                        Answer="Beach or Lake House",
                     },        

                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="1"  ,
                        Answer="Can't compare them",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="27"  ,
                        Answer="Apples, hates Oranges",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="21"  ,
                        Answer="Oranges",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="9"  ,
                        Answer="Mandarins and Clementines",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="8"  ,
                        Answer="All of the Above",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="18"  ,
                        Answer="Oranges and Clementines",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="15"  ,
                        Answer="Apples, Hates Oranges",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="5"  ,
                        Answer="Both",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="6"  ,
                        Answer="Both",
                     },

                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="24"  ,
                        Answer="All of the Above",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="8"  ,
                        Answer="All of the Above",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="1"  ,
                        Answer="Job, especially the portals that make you upload a resume and still fill out all the info",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="9"  ,
                        Answer="Job",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="13"  ,
                        Answer="Job",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="23"  ,
                        Answer="Job",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="27"  ,
                        Answer="Parisian Housing Applications",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="5"  ,
                        Answer="Housing",
                     },

                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="1"  ,
                        Answer="Body Wash",                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="27"  ,
                        Answer="Body Wash",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="17"  ,
                        Answer="Body Wash",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="10"  ,
                        Answer="Body Wash",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="13"  ,
                        Answer="Savon de Marseille: Old Fashioned Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="9"  ,
                        Answer="Bar at home, Body Wash everywhere else",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="8"  ,
                        Answer="Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="24"  ,
                        Answer="Organic Free Range Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="18"  ,
                        Answer="Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="6"  ,
                        Answer="Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="5"  ,
                        Answer="Both",
                     },

                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="18"  ,
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="20"  ,
                        Answer="Whatsapp",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="8"  ,
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="11"  ,
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="9"  ,
                        Answer="LinkedIn",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="24"  ,
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="Karen"  ,
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="5"  ,
                        Answer="IG Video",
                     },    
                     new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="1 "  ,
                        Answer="Galapagos Island",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="24"  ,
                        Answer="Tibet",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="18"  ,
                        Answer="All of Europe",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="27"  ,
                        Answer="Japan",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="17"  ,
                        Answer="Japan",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="17"  ,
                        Answer="Atlantic Ocean",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="15"  ,
                        Answer="South East Asia",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="22"  ,
                        Answer="Nothern Lights in Norway",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="9"  ,
                        Answer="South Africa, Madagascar, East Africa",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="21"  ,
                        Answer="Pacific Crest Trail in British Columbia",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="20"  ,
                        Answer="Japan",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="6"  ,
                        Answer="Japan",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="10"  ,
                        Answer="South East Asia and Australia",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="23"  ,
                        Answer="Iceland and Antartica",
                     }  
                        



                );

           
                context.SaveChanges();
            }
        }
    }
}




