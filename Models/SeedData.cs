using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HomeBase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QOTDContext (
                serviceProvider.GetRequiredService<DbContextOptions<QOTDContext>>()))
            {
                // Look for any movies.
                if (context.ParticipantQOTD.Any())
                {
                    return;   // DB has been seeded
                }

                context.ParticipantQOTD.AddRange(
                     
                     new ParticipantQOTD
                     {
                        GivenName= "Khalil",
                        FamilyName="Jolibois",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Charles",
                        FamilyName="Lhermitte",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Enzo",
                        FamilyName="Martin",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Manon",
                        FamilyName="Grana",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Elisa",
                        FamilyName="Martinez",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Andres",
                        FamilyName="Saenz",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Jean",
                        FamilyName="Hirschfeld",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Lea",
                        FamilyName="Powell",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Ericka",
                        FamilyName="Bourraine",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },                     
                     new ParticipantQOTD
                     {
                        GivenName= "Ann Christine Stephie",
                        FamilyName="Castera",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Samantha",
                        FamilyName="Degroen",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Natalie",
                        FamilyName="Tejero",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Emily",
                        FamilyName="Amat",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Etienne",
                        FamilyName="Descourreges",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Cecile",
                        FamilyName="Mclorin-Salvant",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Gabriella",
                        FamilyName="Guiol",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Marsha ",
                        FamilyName="Samson",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Emmanuelle",
                        FamilyName="Buteau",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Jess",
                        FamilyName="Redal",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },                     
                     new ParticipantQOTD
                     {
                        GivenName= "Karen",
                        FamilyName="Acevedo",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Mariohn",
                        FamilyName="Michel",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Sophia",
                        FamilyName="Khawly",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Steph",
                        FamilyName="Mathurin",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },

                     new ParticipantQOTD
                     {
                        GivenName= "Stephanie",
                        FamilyName="Jean-Pierre",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Alex",
                        FamilyName="Larmier",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     },
                     new ParticipantQOTD
                     {
                        GivenName= "Lara",
                        FamilyName="Hickox",
                        DateCreated=DateTime.Parse("1986-2-23"),
                        Creator="Khalil"
                     }
                     
                );

           
                context.SaveChanges();
            }
        }
    }
}




