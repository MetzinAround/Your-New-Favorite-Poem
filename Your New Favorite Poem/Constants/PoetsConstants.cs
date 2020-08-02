using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Constants
{
    public static class PoetsConstants
    {
        public static IReadOnlyList<Poem> PoemList { get; } = new List<Poem>
        {
            new Poem {Author = "Ocean Vuong", Title = "One Day I'll Love Ocean Vuong", URL = new Uri ("https://www.poetryinvoice.com/poems/someday-ill-love-ocean-vuong")},
            new Poem {Author = "Ocean Vuong", Title = "Untitled (Blue, Green, & Brown)", URL = new Uri ("https://www.triquarterly.org/issues/issue-146/untitled-blue-green-brown-oil-canvas-mark-rothko-1952")},
            new Poem {Author = "Mary Oliver", Title = "The Summer Day", URL = new Uri ("https://wordsfortheyear.com/2015/06/21/the-summer-day-by-mary-oliver/")},
            new Poem {Author = "Mary Oliver", Title = "Wild Geese", URL = new Uri ("http://www.phys.unm.edu/~tw/fas/yits/archive/oliver_wildgeese.html")},
            new Poem {Author = "Layli Long Soldier", Title = "38", URL = new Uri ("https://onbeing.org/poetry/38/")},
            new Poem {Author = "Layli Long Soldier", Title = "Obligations 2", URL = new Uri ("https://www.poetryfoundation.org/poems/149976/obligations-2")},
            new Poem {Author = "Terrance Hayes", Title =  "I lock you in an American sonnet that is part prison", URL = new Uri ("https://www.poetryfoundation.org/poetrymagazine/poems/143917/american-sonnet-for-my-past-and-future-assassin-598dc83c976f1")},
            new Poem {Author = "Terrance Hayes", Title = "Probably, Ghosts Are Allergic To Us. Our Uproarious", URL = new Uri ("https://rhymings.com/terrance-hayes/probably-ghosts-are-allergic-to-us-our-uproarious/")},
            new Poem {Author = "Shay Alexi", Title = "John Mayer's 'Your Body is a Wonderland'is Kinda Gross But", URL = new Uri ("http://www.glass-poetry.com/journal/2018/may/alexi-john.html")},
            new Poem {Author = "Shay Alexi", Title = "OUR MOTHER IS A NIGHTWITCH OR AN ODE TO FEMME FRIENDSHIP", URL = new Uri ("https://tinderboxpoetry.com/our-mother-is-a-nightwitch-or-an-ode-to-femme-friendship")},
            new Poem {Author = "Marci Calabretta Cancio-Bello", Title = "In the Animal Garden of My Body", URL = new Uri ("https://poets.org/poem/animal-garden-my-body")},
            new Poem {Author = "Marci Calabretta Cancio-Bello", Title = "Vase of Ashes", URL = new Uri ("https://www.tupeloquarterly.com/vase-of-ashes-by-marci-calabretta-cancio-bello/")},
            new Poem {Author = "Martín Espada", Title = "Flowers and Bullets", URL = new Uri ("https://poets.org/poem/flowers-and-bullets")},
            new Poem {Author = "Martín Espada", Title = "How We Could Have Lived or Died This Way", URL = new Uri ("https://poets.org/poem/how-we-could-have-lived-or-died-way")}

        };
    }
}
