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

        public bool IsAfgevinkt => TijdstipAfgevinkt != null;
    }
}
