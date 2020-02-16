using OpenSpeelkaarten.Comparators;
using OpenSpeelkaarten.Structures.Cards;
using OpenSpeelkaarten.Structures.SLL;
using OpenSpeelkaarten.Structures.Stack;

//  De OpenSpeelkaarten applicatie is op te delen in twee onderdelen, één deel datastructuren ("Structures" map) en één deel algoritmiek
//  ("Searchers" en "Sorters" map). Beide onderdelen bevatten een basis structuur voor een applicatie waarin gewerkt wordt met kaarten 
//  echter mist hierin de implementatie van gedrag. Het is dan ook de opdracht om deze missende functionaliteit toe te voegen.

//  De opbouw van classes is als volgt:
//  1. Interface      (Definitie van gedrag voor een class)
//  2. Abstract Class (Definitie van attributen, implementatie van gedrag (mits mogelijk))
//  3. Class          (Instatieren van variabelen en implementatie van gedrag (mits nodig))

//  Om de applicatie in "chronologische volgorde" af te maken volg je de volgende stappen:
//              Week 1
//  1. Structures -> Nodes -> SingleLinkedListNodes
//  2. Structures -> SLL
//  3. Structures -> Stack
//  4. Structures -> Queue
//              Week 2 
//  5. Sorters 
//              Week 3
//  6. Structures -> Nodes -> TreeNodes
//  7. Structures -> Tree
//              Extra
//  8. Searchers (Optioneel)

//  Voor het aanvullen van de methodes in de applicatie; kan je het volgende stappen plan gebruiken:
//  1. Noteer de verschillende "cases".
//  2. Schrijf pseudo code per case.
//  3. Zet je pseudo code om naar "echte" code.

namespace OpenSpeelkaarten
{
    class Program
    {
        /// <summary>
        /// Delete all code and 
        /// Perform tests to see if your implementation of datastructures and algorithms work.
        /// </summary>
        static void Main(string[] args)
        {
            Deck shuffledDeck = new Deck();
            Deck unshuffledDeck = new Deck(false);

            ISingleLinkedList<Card> fstHand = new SingleLinkedList<Card>();
            ISingleLinkedList<Card> sndHand = new SingleLinkedList<Card>();

            int index = 0;
            while (index < 7)
            {
                fstHand.Insert(shuffledDeck.Pop());
                sndHand.Insert(unshuffledDeck.Pop());
                index++;
            }

            fstHand.Display();
            sndHand.Display();
        }
    }
}
