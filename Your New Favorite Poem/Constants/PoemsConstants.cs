using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Constants
{
    public static class PoemsConstants
    {
        public static IReadOnlyList<Author> AuthorList { get; } = new List<Author>
        {
            new Author
            {
                Name = "Ocean Vuong",
                IsVerified = true,
                Bio = "Coming Soon",
                PictureURL = new Uri("https://www.thenation.com/wp-content/uploads/2019/12/Ocean-Vuong-1-credit-Peter-Bienkowski.jpg"),
                PictureAltText = "Picture of the poet Ocean Vuong. He is sitting and smiling in a blue sweater.",
                Poems = new List<Poem>
                {
                    new Poem
                    {
                      Title = "One Day I'll Love Ocean Vuong",
                      URL = new Uri ("https://www.poetryinvoice.com/poems/someday-ill-love-ocean-vuong"),
                      IsVerified = true,
                    },
                    new Poem
                    {
                      Title = "Untitled (Blue, Green, & Brown)",
                      URL = new Uri ("https://www.triquarterly.org/issues/issue-146/untitled-blue-green-brown-oil-canvas-mark-rothko-1952"),
                      IsVerified = true,
                    }
                }
            },
            new Author
            {
                Name = "Layli Long Soldier",
                Bio = "Coming Soon",
                IsVerified = true,
                PictureURL = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/d/d5/Layli_Long_Soldier_172902.jpg/330px-Layli_Long_Soldier_172902.jpg"),
                PictureAltText = "Picure of the poet Layli Long Soldier. She is standing behind a podium in a black and white shawl giving a speech ",
                Poems = new List<Poem>
                {
                    new Poem
                    {
                        Title =  "38",
                        URL = new Uri ("https://onbeing.org/poetry/38/"),
                        IsVerified = true,
                    },
                    new Poem
                    {
                        Title = "Obligations 2",
                        URL = new Uri ("https://www.poetryfoundation.org/poems/149976/obligations-2"),
                        IsVerified = true,
                    }
                }
            },

            new Author
            {
                Name = "Mary Oliver",
                Bio = "Coming Soon",
                IsVerified = true,
                PictureURL = new Uri("https://media.newyorker.com/photos/5c4369fcaeb70d48728418ac/master/w_2560%2Cc_limit/Aizenman-MaryOliverTNY-1.jpg"),
                PictureAltText = "A black and white photo of Mary Oliver. She is standing outside and looking to her left. ",
                Poems = new List<Poem>
                {
                     new Poem
                     {
                        Title = "The Summer Day",
                        URL = new Uri ("https://wordsfortheyear.com/2015/06/21/the-summer-day-by-mary-oliver/"),
                        IsVerified = true,
                     },
                     new Poem
                     {
                        Title = "Wild Geese",
                        URL = new Uri ("http://www.phys.unm.edu/~tw/fas/yits/archive/oliver_wildgeese.html"),
                        IsVerified = true
                     }
                }

            },

            new Author
            {
                Name = "Terrance Hayes",
                Bio = "Coming Soon",
                IsVerified = true,
                PictureURL = new Uri("https://media.poetryfoundation.org/uploads/media/default/0001/19/198496b3f730c85668327e98d20f7bd9906064e2.jpeg?w=1274&h=&fit=max&1274"),
                PictureAltText = " A black and white photo of Terrance Hayes' face. He is standing in the shadow of blinds, casting light across his face in stripes.",
                Poems = new List<Poem>
                {
                    new Poem
                    {
                        Title = "I lock you in an American sonnet that is part prison",
                        URL = new Uri ("https://www.poetryfoundation.org/poetrymagazine/poems/143917/american-sonnet-for-my-past-and-future-assassin-598dc83c976f1"),
                        IsVerified = true
                    },
                    new Poem
                    {
                        Title = "Probably, Ghosts Are Allergic To Us. Our Uproarious",
                        URL = new Uri("https://rhymings.com/terrance-hayes/probably-ghosts-are-allergic-to-us-our-uproarious/"),
                        IsVerified = true
                    }
                }

            },

            new Author
            {
                Name ="Shay Alexi",
                Bio = "Coming Soon",
                IsVerified = true,
                PictureURL = new Uri("https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F58740676%2F139090090596%2F1%2Foriginal.20190318-174408?auto=compress&s=3d4ce76e5ea4d37b47e63a4524f585f3"),
                PictureAltText = "Shay Alexi is standing and looking at the camera with one arm across their body and the other posing up towards their face.",
                Poems = new List<Poem>
                {
                    new Poem
                    {
                        Title = "John Mayer's 'Your Body is a Wonderland'is Kinda Gross But",
                        URL = new Uri("http://www.glass-poetry.com/journal/2018/may/alexi-john.html"),
                        IsVerified = true
                    },

                    new Poem
                    {
                        Title = "OUR MOTHER IS A NIGHTWITCH OR AN ODE TO FEMME FRIENDSHIP",
                        URL = new Uri("https://tinderboxpoetry.com/our-mother-is-a-nightwitch-or-an-ode-to-femme-friendship"),
                        IsVerified = true

                    }
                }

            },

            new Author
            {
                Name = "Marci Calabretta Cancio-Bello",
                Bio = "Coming Soon",
                IsVerified = true,
                PictureURL = new Uri("https://149349728.v2.pressablecdn.com/wp-content/uploads/2019/03/Marci-Calabretta-Cancio-Bello-c-Margarita-Corporan-high-res-1-1024x998.jpg"),
                PictureAltText = "Headshot of Marci Calabretta Cancio-Bello. She is standing outside and the background is blurry. She is smiling at the camera.",
                Poems = new List<Poem>
                {
                    new Poem
                    {
                        Title = "In the Animal Garden of My Body",
                        URL = new Uri("https://poets.org/poem/animal-garden-my-body"),
                        IsVerified = true
                    },

                    new Poem
                    {
                        Title = "Vase of Ashes",
                        URL = new Uri("https://www.tupeloquarterly.com/vase-of-ashes-by-marci-calabretta-cancio-bello/"),
                        IsVerified = true
                    }
                }
            },

            new Author
            {
                Name = "Martín Espada",
                Bio = "Coming Soon",
                IsVerified = true,
                PictureURL = new Uri("https://onwisconsin.uwalumni.com/content/uploads/2010/02/Espada_Martin_port09_4056.jpg"),
                PictureAltText = "Poet Martin Espada is lounging in a chair with one arm ofer the back. He is looking at the camera with a serious expression on his face.",
                Poems = new List<Poem>
                {
                    new Poem
                    {
                        Title = "Flowers and Bullets",
                        URL = new Uri("https://poets.org/poem/flowers-and-bullets"),
                        IsVerified = true
                    },

                    new Poem
                    {
                        Title = "How We Could Have Lived or Died This Way",
                        URL = new Uri("https://poets.org/poem/how-we-could-have-lived-or-died-way"),
                        IsVerified = true,
                    }
                }
            }
        };
    }
}
