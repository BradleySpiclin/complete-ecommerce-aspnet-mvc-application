﻿using eGameStore.Models;

namespace eGameStore.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (context != null)
                {
                    context.Database.EnsureCreated();

					// Developer
					if (!context.Developer.Any())
                    {
                        context.Developer.AddRange(new List<Developer>()
                        {
                                new Developer()
                                {
                                    FullName = "Amazing Game Studio",
                                    ProfilePictureURL = "https://i.imgur.com/OVZEp5O.png",
                                    Bio = "Bio for amazing game studio"
                                },
                                new Developer()
                                {
                                    FullName = "Hawkshot Games",
                                    ProfilePictureURL = "https://i.imgur.com/OVZEp5O.png",
                                    Bio = "Bio for hawkshot games"
                                },
                                new Developer()
                                {
                                    FullName = "Mighty studios",
                                    ProfilePictureURL = "https://i.imgur.com/OVZEp5O.png",
                                    Bio = "Bio for mighty studios"
                                },
                            });
                        context.SaveChanges();

                    }
                    // Publisher
                    if (!context.Publisher.Any())
                    {
                        context.Publisher.AddRange(new List<Publisher>()
                            {
                                new Publisher()
                                {
                                    FullName = "Blizzard Entertainment",
                                    ProfilePictureURL = "https://i.imgur.com/yrl3McY.jpg",
                                    Bio = "Bio for blizzard entertainment"
                                },
                                new Publisher()
                                {
                                    FullName = "Electronic Arts",
                                    ProfilePictureURL = "https://i.imgur.com/yrl3McY.jpg",
                                    Bio = "Bio for EA"
                                },
                                new Publisher()
                                {
                                    FullName = "Microsoft",
                                    ProfilePictureURL = "https://i.imgur.com/yrl3McY.jpg",
                                    Bio = "Bio for microsoft"
                                },

                        });
                        context.SaveChanges();
                    }

					// Game
					if (!context.Games.Any())
					{
						context.Games.AddRange(new List<Game>()
						{
								new Game()
					{
						Name = "Overwatch 2",
						ImageURL = "https://i.imgur.com/S44XyA5.jpg",
						Description = "This is Overwatch 2 description",
						Price= 44.00,
                        DeveloperId = 1,
                        PublisherId = 2,
                        ReleaseDate= DateTime.Now.AddDays(-30),
						GameGenre = Enums.GameGenre.Shooter
					},
					new Game()
					{
						Name = "League of Legends",
						ImageURL = "https://i.imgur.com/xZtW6BL.jpg",
						Description = "This is league of legends description",
						Price= 15.00,
                        DeveloperId = 3,
                        PublisherId = 3,
                        ReleaseDate= DateTime.Now.AddDays(-50),
						GameGenre = Enums.GameGenre.Strategy
					},
					new Game()
					{
						Name = "Elden Ring",
						ImageURL = "https://i.imgur.com/xSJjems.jpg",
						Description = "This is elden ring description",
						Price= 75.00,
                        DeveloperId = 1,
                        PublisherId = 1,
                        ReleaseDate= DateTime.Now.AddDays(-70),
						GameGenre = Enums.GameGenre.RoleplayingGame
					},
					new Game()
					{
						Name = "Age of Empires",
						ImageURL = "https://i.imgur.com/5Z5ZewM.jpg",
						Description = "This is age of empires description",
						Price= 15.00,
                        DeveloperId = 2,
                        PublisherId = 3,
                        ReleaseDate= DateTime.Now.AddDays(-5000),
						GameGenre = Enums.GameGenre.Strategy
					},
					new Game()
					{
						Name = "Dota 2",
						ImageURL = "https://i.imgur.com/ajkDVSD.jpg",
						Description = "This is dota 2 description",
						Price= 15.00,
                        DeveloperId = 1,
                        PublisherId= 3,
                        ReleaseDate= DateTime.Now.AddDays(-651),
						GameGenre = Enums.GameGenre.Strategy
					},
						});
						context.SaveChanges();
					}
				}
            }
        }
    }
}
