using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TodoObjectModel;

namespace TodoTests
{
    [TestClass]
    public class UnitTest1
    {

        private Persoon _persoon;

        [TestInitialize]
        public void SetUp()
        {
            _persoon = new Persoon();
        } 

        [TestMethod]
        public void MaakNieuweTaak()
        {
            var item = _persoon.VoegItemToe("Doe iets");
            Assert.AreEqual(item, _persoon.TodoItems.First());
        }

        [TestMethod, ExpectedException(typeof(TodoItemBestaatAlException))]
        public void KanNietTweeKeerDezelfdeTaakToevoegen()
        {
            var titel = "Doe dit";
            _persoon.VoegItemToe(titel);
            _persoon.VoegItemToe(titel);
        }

        [TestMethod]
        public void AantalTakenNaToevoegen()
        {
            for (int i = 0; i < 10; i++)
            {
                _persoon.VoegItemToe($"Taak {i}");
                Assert.AreEqual(i+1, _persoon.AantalActieveTaken);
            }
        }

        [DataTestMethod,
            DataRow(10, 4),
            DataRow(15,14),
            DataRow(5,5),
            DataRow(7,0)]
        public void AantalActieveTakenNaAfvinken(int aantalAanmaken, int aantalAfvinken)
        {
            var items = new TodoItem[aantalAfvinken];
            for (int i = 0; i < aantalAanmaken; i++)
            {
                var taak = _persoon.VoegItemToe($"taak om af te vinken {i}");
                if(i < aantalAfvinken)
                {
                    items[i] = taak;
                }
            }
            // Vink de eerste 5 items af
            foreach(var taak in items)
            {
                taak.VinkAf();
            }
            Assert.AreEqual(aantalAanmaken - aantalAfvinken, _persoon.AantalActieveTaken);
        }

#warning nog extra tests nodig
    }
}
