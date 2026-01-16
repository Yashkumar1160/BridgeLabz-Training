using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.bookshelf
{
    internal class GenreNode
    {
        //attributes
        public string genre;

        public BookListUtilityImpl bookList;

        public GenreNode next;

        //constructor
        public GenreNode(string genre)
        {
            this.genre = genre;
            this.bookList = new BookListUtilityImpl();
            this.next = null;
        }
    }
}
