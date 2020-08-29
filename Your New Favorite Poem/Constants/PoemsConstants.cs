using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Constants
{
    public static class PoemsConstants
    {
        public static IReadOnlyList<Poem> PoemList { get; } = new List<Poem>
        {
            new Poem ("Ocean Vuong", "One Day I'll Love Ocean Vuong", new Uri ("https://www.poetryinvoice.com/poems/someday-ill-love-ocean-vuong")),
            new Poem ( "Ocean Vuong", "Untitled (Blue, Green, & Brown)",  new Uri ("https://www.triquarterly.org/issues/issue-146/untitled-blue-green-brown-oil-canvas-mark-rothko-1952")),
            new Poem ( "Mary Oliver", "The Summer Day",  new Uri ("https://wordsfortheyear.com/2015/06/21/the-summer-day-by-mary-oliver/")),
            new Poem ( "Mary Oliver", "Wild Geese",  new Uri ("http://www.phys.unm.edu/~tw/fas/yits/archive/oliver_wildgeese.html")),
            new Poem ( "Layli Long Soldier", "38",  new Uri ("https://onbeing.org/poetry/38/")),
            new Poem ( "Layli Long Soldier", "Obligations 2",  new Uri ("https://www.poetryfoundation.org/poems/149976/obligations-2")),
            new Poem ( "Terrance Hayes",  "I lock you in an American sonnet that is part prison",  new Uri ("https://www.poetryfoundation.org/poetrymagazine/poems/143917/american-sonnet-for-my-past-and-future-assassin-598dc83c976f1")),
            new Poem ( "Terrance Hayes",  "Probably, Ghosts Are Allergic To Us. Our Uproarious",  new Uri ("https://rhymings.com/terrance-hayes/probably-ghosts-are-allergic-to-us-our-uproarious/")),
            new Poem ( "Shay Alexi", "John Mayer's 'Your Body is a Wonderland'is Kinda Gross But",  new Uri ("http://www.glass-poetry.com/journal/2018/may/alexi-john.html")),
            new Poem ( "Shay Alexi",  "OUR MOTHER IS A NIGHTWITCH OR AN ODE TO FEMME FRIENDSHIP",  new Uri ("https://tinderboxpoetry.com/our-mother-is-a-nightwitch-or-an-ode-to-femme-friendship")),
            new Poem ( "Marci Calabretta Cancio-Bello",  "In the Animal Garden of My Body",  new Uri ("https://poets.org/poem/animal-garden-my-body")),
            new Poem ( "Marci Calabretta Cancio-Bello",  "Vase of Ashes",  new Uri ("https://www.tupeloquarterly.com/vase-of-ashes-by-marci-calabretta-cancio-bello/")),
            new Poem ( "Martín Espada",  "Flowers and Bullets",  new Uri ("https://poets.org/poem/flowers-and-bullets")),
            new Poem ( "Martín Espada", "How We Could Have Lived or Died This Way",  new Uri ("https://poets.org/poem/how-we-could-have-lived-or-died-way"))

        };
    }
}
