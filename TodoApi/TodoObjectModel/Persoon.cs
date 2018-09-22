using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TodoObjectModel
{
    public class Persoon
    {
        private readonly List<TodoItem> _alleTaken;

        public Persoon()
        {
            _alleTaken = new List<TodoItem>();
        }

        /// <summary>
        /// Naam van de persoon
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// Alle <see cref="TodoItem"/>s van deze persoon
        /// </summary>
        public IEnumerable<TodoItem> TodoItems => ZoekActieveTaken1(); // gebruik één van de 5 altenatieven

        public int AantalActieveTaken => TodoItems.Count(); // Count() is een Linq extension method

        /// <summary>
        /// Zoek actieve taken met een Linq-uitdrukking.
        /// </summary>
        /// <returns>De actieve taken</returns>
        private IEnumerable<TodoItem> ZoekActieveTaken1()
        {
            return from taak in _alleTaken
                   where !taak.IsAfgevinkt
                   select taak;
        }

        /// <summary>
        /// Vertaling van de Linq-uitdrukking in ZoekActieveTaken1 naar Linq extension methods.
        /// </summary>
        /// <returns>De actieve taken</returns>
        private IEnumerable<TodoItem> ZoekActieveTaken2()
        {
            return _alleTaken.
                Where(t => !t.IsAfgevinkt).
                Select(t => t);
        }

        /// <summary>
        /// Optimalisatie van de methode met Linq extension methods in ZoekActieveTaken2.
        /// De Select-methode is niet strikt nodig.
        /// Door Select weg te laten krijg je "lazy evaluation" cadeau.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<TodoItem> ZoekActieveTaken3()
        {
            return _alleTaken.Where(t => !t.IsAfgevinkt);
        }

        /// <summary>
        /// Zoek actieve taken met yield return.
        /// Op deze manier krijg je lazy eveluation cadeau, net zoals bij gebruik van Linq extension methods zonder Select.
        /// </summary>
        /// <returns>De actieve taken</returns>
        private IEnumerable<TodoItem> ZoekActieveTaken4()
        {
            foreach (var taak in _alleTaken)
            {
                if (!taak.IsAfgevinkt)
                {
                    yield return taak;
                }
            }
        }

        /// <summary>
        /// Zoek actieve taken door ze in een nieuwe collectie te steken en die te returnen.
        /// Deze manier van werken heeft zeker niet de voorkeur, tenzij het niet anders kan.
        /// </summary>
        /// <returns>De actieve taken</returns>
        private IEnumerable<TodoItem> ZoekActieveTaken5()
        {
            var actieveTaken = new List<TodoItem>();
            foreach (var taak in _alleTaken)
            {
                if (!taak.IsAfgevinkt)
                {
                    actieveTaken.Add(taak);
                }
            }
            return actieveTaken;
        }



        /// <summary>
        /// Voeg een item toe voor deze persoon en 
        /// </summary>
        /// <param name="todoTitel">titel van het nieuwe todo item</param>
        /// <returns>Het nieuw gemaakte todo item</returns>
        /// <exception cref="TodoItemBestaatAlException">wanneer een actief item met dezelfde titel al bestaat voor deze persoon</exception>
        public TodoItem VoegItemToe(string todoTitel)
        {
            var taak = new TodoItem(todoTitel);
            _alleTaken.Add(taak);
            return taak;
        }
    }
}
