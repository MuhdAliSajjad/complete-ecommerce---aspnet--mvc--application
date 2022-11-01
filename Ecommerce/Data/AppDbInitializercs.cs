using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Models;


namespace Ecommerce.Data
{
    public class AppDbInitializercs
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                //Cinema
                if (!context.cinemas.Any())
                {
                    context.cinemas.AddRange(new List<CinemaModel>()
                    {
                        new CinemaModel()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaModel()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaModel()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaModel()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaModel()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<ActorModel>()
                    {
                        new ActorModel()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio for first actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-1.jpeg" ,
                            //Id=1
                        },
                        new ActorModel()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio for first actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-2.jpeg" ,
                            //Id=2
                        },
                        new ActorModel()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio for first actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-3.jpeg" ,
                            //Id=3
                        },
                        new ActorModel()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio for first actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-4.jpeg" ,
                            //Id=4
                        },
                        new ActorModel()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio for first actor",
                            ProfilePicture = "http://dotnethow.net/images/actors/actor-5.jpeg" ,
                            //Id=5
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<ProducersModel>()
                    {
                        new ProducersModel()
                        {
                            FullName = "Producer 1",
                            Bio = "http://dotnethow.net/images/producers/producer-1.jpeg",
                            ProfilePicture = "This is the Bio for Producer actor"
                        },
                        new ProducersModel()
                        {
                            FullName = "Producer 2",
                            Bio = "http://dotnethow.net/images/producers/producer-2.jpeg",
                            ProfilePicture = "This is the Bio for Producer actor"
                        },
                        new ProducersModel()
                        {
                            FullName = "Producer 3",
                            Bio = "http://dotnethow.net/images/producers/producer-3.jpeg",
                            ProfilePicture = "This is the Bio for Producer actor"
                        },
                        new ProducersModel()
                        {
                            FullName = "Producer 4",
                            Bio = "http://dotnethow.net/images/producers/producer-4.jpeg",
                            ProfilePicture = "This is the Bio for Producer actor"
                        },
                        new ProducersModel()
                        {
                            FullName = "Producer 5",
                            Bio = "http://dotnethow.net/images/producers/producer-5.jpeg",
                            ProfilePicture = "This is the Bio for Producer actor"
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.movies.Any())
                {
                    context.movies.AddRange(new List<MoviesModel>()
                    {
                        new MoviesModel()
                        {
                            Name = "Scoob ",
                            Description = "This is the movie description ",
                            Price = " 39.80",
                            Image = "http://dotnethow.net/images/movies/movies-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId= 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon

                        },
                        new MoviesModel()
                        {
                            Name = "Cold Soles ",
                            Description = "This is the movie description ",
                            Price = " 39.80",
                            Image = "http://dotnethow.net/images/movies/movies-9.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId= 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new MoviesModel()
                        {
                            Name = "Transformers ",
                            Description = "This is the movie description ",
                            Price = " 39.80",
                            Image = "http://dotnethow.net/images/movies/movies-8.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId= 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new MoviesModel()
                        {
                            Name = "Scoob ",
                            Description = "This is the movie description ",
                            Price = " 39.80",
                            Image = "http://dotnethow.net/images/movies/movies-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId= 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new MoviesModel()
                        {
                            Name = "Scoob ",
                            Description = "This is the movie description ",
                            Price = " 39.80",
                            Image = "http://dotnethow.net/images/movies/movies-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId= 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary,

                        },
                    });
                    context.SaveChanges();
                }
                //Actor & Movies
                if (!context.actor_Movies.Any())
                {
                    context.actor_Movies.AddRange(new List<Actor_Movies>()
                    {
                        new Actor_Movies()
                        {
                            ActorId = 5,
                            MovieId = 5
                         
                        },
                        new Actor_Movies()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movies()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new Actor_Movies()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                         new Actor_Movies()
                        {
                            ActorId = 1,
                            MovieId = 4
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
