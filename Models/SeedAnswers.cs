using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HomeBase.Models
{
    public static class SeedAnswers

    {
        public static async System.Threading.Tasks.Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using (var context = new QOTDContext (
                serviceProvider.GetRequiredService<DbContextOptions<QOTDContext>>()))

            {
                // Look for any movies.
                if (context.QOTDAnswer.Any())
                {
                    return;   // DB has been seeded
                }
                var partic= await context.ParticipantQOTD.Select(x=>x).ToListAsync();
                Dictionary<string,int> particDic =new Dictionary<string, int>();
                foreach( var participant in partic){
                  string fullname= $"{participant.GivenName} {participant.FamilyName}";
                  Debug.Print(fullname);
                       particDic.Add(fullname,participant.ID) ;
                }
 List<QOTDAnswer> AllAnswers = new List<QOTDAnswer>(){
                     new QOTDAnswer
                     {
                        Question ="How many Times did Enzo wear a dress in High School?"   ,    
                        QuestionID =1  ,      
                        Author ="23",
                        AuthorName="Enzo Martin"  ,
                        Answer="2",
                     },

                      new QOTDAnswer
                     {
                        Question ="How many Times did Enzo wear a dress in High School?"   ,    
                        QuestionID =1  ,      
                        Author ="1",
                        AuthorName="Khalil Jolibois"  ,
                        Answer="3",
                     },
                      new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="13",
                        AuthorName= "Emily Amat",  
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="24", 
                        AuthorName="Charles Lhermitte"  ,
                        Answer="Hardwood",
                     },
                      new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="15",
                        AuthorName= "Samantha De Groen",  
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="19",
                        AuthorName="Jean Hirschfeld"  ,
                        Answer="Hardwood",
                     },
                      new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="20",
                        AuthorName="Andres Saenz"  ,
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="6",
                        AuthorName= "Karen Acevedo",  
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="5",
                        AuthorName= "Mariohn Michel",  
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="25", 
                        AuthorName="Alex Larmier"  ,
                        Answer="Laminate or Hardwood",
                     },
                      new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="27", 
                        AuthorName="Marilou Gantier",
                        Answer="Hardwood",
                     },
                    new QOTDAnswer
                     {
                        Question ="Hardwood Floors or Carpet?"   ,    
                        QuestionID =2  ,      
                        Author ="1",
                        AuthorName="Khalil Jolibois"  ,
                        Answer="Hardwood",
                     },
              
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="15",
                        AuthorName= "Samantha De Groen",  
                        Answer="Belgian Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="5",
                        AuthorName= "Mariohn Michel",  
                        Answer="Pancakes",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="12",
                        AuthorName= "Etienne Decourreges",  
                        Answer="Panffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="13",
                        AuthorName= "Emily Amat",  
                        Answer="Belgian Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="19", 
                        AuthorName="Jean Hirschfeld"  ,
                        Answer="Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="9",
                        AuthorName= "Marsha Samson",  
                        Answer="Belgian Waffles with Tienen Suga",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="18",
                        AuthorName= "Lea Powell",  
                        Answer="Banana Pancakes",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="22", 
                        AuthorName="Manon Grana"  ,
                        Answer="Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="24", 
                        AuthorName="Charles Lhermitte"  ,
                        Answer="Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="11",
                        AuthorName= "Cecile Mclorin-Salvant",  
                        Answer="Waffles",
                     },
                     new QOTDAnswer
                     {
                        Question ="Waffles or Pancakes?"   ,    
                        QuestionID =3  ,      
                        Author ="1",
                        AuthorName="Khalil Jolibois"  ,
                        Answer="Pancakes",
   
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="22", 
                        AuthorName="Manon Grana"  ,
                        Answer="Sweet Potato Fries",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="19", 
                        AuthorName="Jean Hirschfeld"  ,
                        Answer="French Fries",
                     },
                      new QOTDAnswer
                     {
                        Question ="French Fries or Sweet Potato Fries?"   ,    
                        QuestionID =4  ,      
                        Author ="27",
                        AuthorName="Marilou Gantier",
                        Answer="Paris",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="6",
                        AuthorName= "Karen Acevedo",  
                        Answer="Miami",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="11",AuthorName= "Cecile Mclorin-Salvant",  
                        Answer="Brooklyn, China, Australia",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="21", AuthorName="Elisa Martinez"  ,
                        Answer="Miami",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="13",AuthorName= "Emily Amat",  
                        Answer="Paris",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="12 "  ,                       
                         AuthorName= "Etienne Decourreges",  

                        Answer="Paris and Ireland",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="19", AuthorName="Jean Hirschfeld"  ,
                        Answer="Melbourne, Florida",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="7",AuthorName= "Jess Redal",  
                        Answer="Tahiti",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="15",AuthorName= "Samantha De Groen",  
                        Answer="Montreal",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="14",AuthorName= "Natalie Tejero",  
                        Answer="Boston",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="24", AuthorName="Charles Lhermitte"  ,
                        Answer="Lausanne",
                     },
                      new QOTDAnswer
                     {
                        Question ="Where does everyone live now?"   ,    
                        QuestionID =5  ,      
                        Author ="10",AuthorName= "Gabriella Guiol",  
                        Answer="Atlanta",
                     }, 
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="21", AuthorName="Elisa Martinez"  ,
                        Answer="Seignot",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="1",AuthorName="Khalil Jolibois"  ,
                        Answer="All Three",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="13",AuthorName= "Emily Amat",  
                        Answer="Carrenard",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="6",AuthorName= "Karen Acevedo",  
                        Answer="Seignot",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="19", AuthorName="Jean Hirschfeld"  ,
                        Answer="Forrest",
                     },
                      new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="18",AuthorName= "Lea Powell",  
                        Answer="Carrenard",
                     },
                    new QOTDAnswer
                     {
                        Question ="Mr Seignot, MMe Forest or MMe Carrenard?"   ,    
                        QuestionID =6  ,      
                        Author ="24", AuthorName="Charles Lhermitte"  ,
                        Answer="Seignot",
                     },


                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="24", AuthorName="Charles Lhermitte"  ,
                        Answer="Dogs, cats are assholes",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="21", AuthorName="Elisa Martinez"  ,
                        Answer="All pets except birds",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="1",AuthorName="Khalil Jolibois"  ,
                        Answer="Cats",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="18",AuthorName= "Lea Powell",  
                        Answer="Dogs",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="8",AuthorName= "Emmanuelle Buteau",  
                        Answer="Dogs",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="12",AuthorName= "Etienne Decourreges",  
                        Answer="Chiats",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="25", AuthorName="Alex Larmier"  ,
                        Answer="Dogs",
                     },
                       new QOTDAnswer
                     {
                        Question ="Cats or Dogs?"   ,    
                        QuestionID =7  ,      
                        Author ="5",AuthorName= "Mariohn Michel",  
                        Answer="Dogs",
                     },
            

                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="9",AuthorName= "Marsha Samson",  
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="18",AuthorName= "Lea Powell",  
                        Answer="Both",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="17",AuthorName= "Ericka Bourraine",  
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="1",AuthorName="Khalil Jolibois"  ,
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="5",AuthorName= "Mariohn Michel",  
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="8",AuthorName= "Emmanuelle Buteau",  
                        Answer="Van Gogh",
                     },
                      new QOTDAnswer
                     {
                        Question ="Picasso or Van Gogh?"   ,    
                        QuestionID =8  ,      
                        Author ="11",AuthorName= "Cecile Mclorin-Salvant",  
                        Answer="Both",
                     },

                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="5",AuthorName= "Mariohn Michel",  
                        Answer="Fuck Snow except first snowfall",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="18",
                        AuthorName= "Lea Powell",  
                        Answer="Yay Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="1",AuthorName="Khalil Jolibois"  ,
                        Answer="Fuck Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="13",AuthorName= "Emily Amat",  
                        Answer="Yay Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="15",AuthorName= "Samantha De Groen",  
                        Answer="Fuck Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="8",AuthorName= "Emmanuelle Buteau",  
                        Answer="Yay Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="9",AuthorName= "Marsha Samson",  
                        Answer="F Snow",
                     },
                       new QOTDAnswer
                     {
                        Question ="Yay Snow or Fuck Snow?"   ,    
                        QuestionID =9  ,      
                        Author ="7",AuthorName= "Jess Redal",  
                        Answer="No to Snow, also the weather in Tahiti is great",
                     },

                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="4",AuthorName= "Sophia Khawly",
                        Answer="88",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="9",AuthorName= "Marsha Samson",  
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="1",AuthorName="Khalil Jolibois"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="13",AuthorName= "Emily Amat",  
                        Answer="89",
                         

                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="20", 
                        AuthorName="Andres Saenz"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="15",
                        AuthorName= "Samantha De Groen",  
                        Answer="90",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="8",
                        AuthorName= "Emmanuelle Buteau",  
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="21", 
                        AuthorName="Elisa Martinez"  ,
                        Answer="89",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="17",
                        AuthorName= "Ericka Bourraine",  
                        Answer="88",
                     },
                       new QOTDAnswer
                     {
                        Question ="Best Birth Year: 1988 ,1989 or 1990?"   ,    
                        QuestionID =10  ,      
                        Author ="24",
                        AuthorName="Charles Lhermitte"  ,
                        Answer="88",
                     },

                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="1",AuthorName="Khalil Jolibois"  ,
                        Answer="Beach House",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="21", AuthorName="Elisa Martinez"  ,
                        Answer="Beach House or Mountain Cabin",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="22", AuthorName="Manon Grana"  ,
                        Answer=" Beach/Lake House",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="18",
                        AuthorName= "Lea Powell",  

                        Answer="Beach or Lake House if it doesn't look like a scary movie serial killer house",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="9",
                        AuthorName= "Marsha Samson" ,
                        Answer="Beach House on a Mountain",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="24", 
                        AuthorName="Charles Lhermitte"  ,
                        Answer="Mountain Chalet",
                     },    
                       new QOTDAnswer
                     {
                        Question ="Cruise, Beach/Lake House or Ski Chalet?"   ,    
                        QuestionID =11  ,      
                        Author ="5",
                        AuthorName= "Mariohn Michel", 
                        Answer="Beach or Lake House",
                     },        

                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="1",
                        AuthorName="Khalil Jolibois"  ,
                        Answer="Can't compare them",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="27",
                         AuthorName="Marilou Gantier",
                        Answer="Apples, hates Oranges",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="21", 
                        AuthorName="Elisa Martinez"  ,
                        Answer="Oranges",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="9",
                        AuthorName= "Marsha Samson",  
                        Answer="Mandarins and Clementines",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="8",
                        AuthorName= "Emmanuelle Buteau",  
                        Answer="All of the Above",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="18",
                        AuthorName= "Lea Powell",  
                        Answer="Oranges and Clementines",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="15",
                        AuthorName= "Samantha De Groen",  
                        Answer="Apples, Hates Oranges",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="5",
                        AuthorName= "Mariohn Michel",  
                        Answer="Both",
                     },
                      new QOTDAnswer
                     {
                        Question ="Apples or Oranges?"   ,    
                        QuestionID =12  ,      
                        Author ="6",
                        AuthorName= "Karen Acevedo",  
                        Answer="Both",
                     },

                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="24", 
                        AuthorName="Charles Lhermitte"  ,
                        Answer="All of the Above",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="8",
                        AuthorName= "Emmanuelle Buteau",  
                        Answer="All of the Above",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="1",
                        AuthorName="Khalil Jolibois"  ,
                        Answer="Job, especially the portals that make you upload a resume and still fill out all the info",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="9",
                        AuthorName= "Marsha Samson", 
                        Answer="Job",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="13",
                        AuthorName= "Emily Amat",  
                        Answer="Job",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="23", 
                        AuthorName="Enzo Martin"  ,
                        Answer="Job",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="27", 
                        AuthorName="Marilou Gantier",
                        Answer="Parisian Housing Applications",
                     },
                      new QOTDAnswer
                     {
                        Question =" least favorite: job applications , housing applications or school applications?"   ,    
                        QuestionID =13  ,      
                        Author ="5",
                        AuthorName= "Mariohn Michel",  
                        Answer="Housing",
                     },

                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="1",AuthorName="Khalil Jolibois"  ,
                        Answer="Body Wash",                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="27", 
                        AuthorName="Marilou Gantier",
                        Answer="Body Wash",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="17",
                        AuthorName= "Ericka Bourraine",  
                        Answer="Body Wash",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="10",
                        AuthorName= "Gabriella Guiol",  
                        Answer="Body Wash"
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="13",
                        AuthorName= "Emily Amat",  
                        Answer="Savon de Marseille: Old Fashioned Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="9",
                        AuthorName= "Marsha Samson",  
                        Answer="Bar at home, Body Wash everywhere else",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="8",
                        AuthorName= "Emmanuelle Buteau",  
                        Answer="Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="24", 
                        AuthorName="Charles Lhermitte"  ,
                        Answer="Organic Free Range Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="18",
                        AuthorName= "Lea Powell",  
                        Answer="Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="6",
                        AuthorName= "Karen Acevedo",  
                        Answer="Bar Soap",
                     },
                       new QOTDAnswer
                     {
                        Question ="Bar Soap or Body Wash?"   ,    
                        QuestionID =14  ,      
                        Author ="5",
                        AuthorName= "Mariohn Michel",  
                        Answer="Both",
                     },

                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="18",
                        AuthorName= "Lea Powell",  
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="20", 
                        AuthorName="Andres Saenz"  ,
                        Answer="Whatsapp",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="8",
                        AuthorName= "Emmanuelle Buteau",  
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="11",
                        AuthorName= "Cecile Mclorin-Salvant", 
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="9",
                        AuthorName= "Marsha Samson"  ,
                        Answer="LinkedIn",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="24", 
                        AuthorName="Charles Lhermitte"  ,
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="6",
                        AuthorName= "Karen Acevedo",  
                        Answer="IG Video",
                     },
                     new QOTDAnswer
                     {
                        Question ="Snap Chat or Instagram Video?"   ,    
                        QuestionID =15  ,      
                        Author ="5",
                        AuthorName= "Mariohn Michel",  
                        Answer="IG Video",
                     },    
                     new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="1 "  ,
                        AuthorName= "Khalil Jolibois",  
                        Answer="Galapagos Island",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="24",
                        AuthorName="Charles Lhermitte"  ,
                        Answer="Tibet",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="18",
                        AuthorName= "Lea Powell" ,
                        Answer="All of Europe",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="27", 
                        AuthorName="Marilou Gantier",
                        Answer="Japan",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="17",
                        AuthorName= "Ericka Bourraine", 
                        Answer="Japan",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="17",
                        AuthorName= "Ericka Bourraine", 
                        Answer="Atlantic Ocean",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="15",
                        AuthorName= "Samantha De Groen",
                        Answer="South East Asia",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="22", 
                        AuthorName="Manon Grana"  ,
                        Answer="Nothern Lights in Norway",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="9",
                        AuthorName= "Marsha Samson",  
                        Answer="South Africa, Madagascar, East Africa",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="21", 
                        AuthorName="Elisa Martinez"  ,
                        Answer="Pacific Crest Trail in British Columbia",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="20",
                        AuthorName="Andres Saenz"  ,
                        Answer="Japan",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="6",
                        AuthorName= "Karen Acevedo",  
                        Answer="Japan",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="10",
                        AuthorName= "Gabriella Guiol",  
                        Answer="South East Asia and Australia",
                     },
                       new QOTDAnswer
                     {
                        Question ="No Limits: You get to travel anywhere in the word"   ,    
                        QuestionID =16 ,      
                        Author ="23", 
                        AuthorName="Enzo Martin"  ,
                        Answer="Iceland and Antartica",
                     }  
 };
 foreach( var entry in AllAnswers){
   Debug.Print("---------------------------");
   Debug.Print(entry.AuthorName);
     Debug.Print(particDic[entry.AuthorName].ToString());

  entry.Author=particDic[entry.AuthorName].ToString();
 }

                context.QOTDAnswer.AddRange(
                     
AllAnswers

                );

           
                context.SaveChanges();
            }
        }
    }
}




