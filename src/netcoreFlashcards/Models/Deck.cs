using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreFlashcards.Models
{
    public class Deck
    {
        public List<IFlashCard> Cards { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


    }
}
