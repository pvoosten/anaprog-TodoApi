using System;
using System.Collections.Generic;
using System.Text;

namespace TodoObjectModel
{

    /// <summary>
    /// Een taak of todo item
    /// </summary>
    public class TodoItem
    {
        private readonly string _todoTitel;

        public TodoItem(string todoTitel)
        {
            Id = VolgendId;
            _todoTitel = todoTitel;
        }

        public static int VolgendId { get; set; } = 1000;

        /// <summary>
        /// Uniek identificatienummer van deze taak
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// De titel van een taak
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Het tijdstip waarop deze taak werd aangeduid als voltooid
        /// </summary>
        public DateTime? TijdstipAfgevinkt { get; set; }

        public bool IsAfgevinkt => TijdstipAfgevinkt != null; // gebruik "lampje" om om te zetten naar voluit geschreven property of omgekeerd

        public void VinkAf() => TijdstipAfgevinkt = DateTime.Now; // gebruik "lampje" om om te zetten naar methode met accolades of omgekeerd
    }
}
