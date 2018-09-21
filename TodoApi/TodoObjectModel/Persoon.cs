using System;
using System.Collections.Generic;
using System.Text;

namespace TodoObjectModel
{
    public class Persoon
    {
        /// <summary>
        /// Naam van de persoon
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// Alle <see cref="TodoItem"/>s van deze persoon
        /// </summary>
        public IEnumerable<TodoItem> TodoItems { get; }

        /// <summary>
        /// Voeg een item toe voor deze persoon en 
        /// </summary>
        /// <param name="todoTitel">titel van het nieuwe todo item</param>
        /// <returns>Het nieuw gemaakte todo item</returns>
        /// <exception cref="TodoItemBestaatAlException">wanneer een actief item met dezelfde titel al bestaat voor deze persoon</exception>
        public TodoItem VoegItemToe(string todoTitel)
        {
            throw new NotImplementedException();
        }
    }
}
