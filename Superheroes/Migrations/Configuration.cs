namespace Superheroes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Superheroes.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Superheroes.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Superheroes.Models.ApplicationDbContext context)
        {
            context.Superhero.AddOrUpdate(x => x.Id,
                new Superhero() { Name = "Spider-Man", AlterEgo = "Peter Parker", PrimaryAbility = "Making spider webs", SecondaryAbility = "Leaping buildings", CatchPhrase = "My spidey sense are tingling." },
                new Superhero() { Name = "Hulk", AlterEgo = "Bruce Banner", PrimaryAbility = "Superhuman strength", SecondaryAbility = "Regeneration", CatchPhrase = "HULK SMASH" },
                new Superhero() { Name = "Iron Man", AlterEgo = "Tony Stark", PrimaryAbility = "Armor suit", SecondaryAbility = "Intellect", CatchPhrase = "I am Iron Man." },
                new Superhero() { Name = "Batman", AlterEgo = "Bruce Wayne", PrimaryAbility = "Intellect", SecondaryAbility = "Martial Arts", CatchPhrase = "To the bat-pole Robin!" },
                new Superhero() { Name = "Wonder Woman", AlterEgo = "Diana Prince", PrimaryAbility = "Martial Arts", SecondaryAbility = "Stopping bullets" },
                new Superhero() { Name = "Superman", AlterEgo = "Clark Kent", PrimaryAbility = "Superhuman strength", SecondaryAbility = "Durability", CatchPhrase = "Up, up, and away!" });
        }
    }
}
