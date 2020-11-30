using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace MyWork.Models
{
    public class Note
    {
        /// <summary>
        /// Название организации
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// Наименование работ
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Количество потраченных часов
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// Дата исполнения
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Оплачевается ли работа
        /// </summary>
        public bool IsPayable { get; set; }
    }
}
