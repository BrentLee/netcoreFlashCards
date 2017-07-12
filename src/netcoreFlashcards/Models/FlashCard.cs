using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreFlashcards.Models
{

    public class FlashCard : IFlashCard
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
    public interface IFlashCard
    {
        string Question { get; set; }
        string Answer { get; set; }
    }
}
