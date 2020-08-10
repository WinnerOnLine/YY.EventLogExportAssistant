﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YY.EventLogExportAssistant.Database.Models
{
    public class TransactionStatuses : ReferenceObject
    {
        #region Private Static Members

        private static readonly Dictionary<string, string> _mapPresentation = new Dictionary<string, string>()
        {
            { "Committed", "Зафиксирована" },
            { "Unfinished", "Не завершена" },
            { "NotApplicable", "Нет транзакции" },
            { "RolledBack", "Отменена" },
            { "Unknown", "Неизвестно" }
        };

        #endregion

        #region Private Static Methods

        private static string GetPresentationByName(string name)
        {
            return _mapPresentation.TryGetValue(name, out string output) ? output : name;
        }

        #endregion

        #region Public Members

        [MaxLength(500)]
        public string Presentation
        {
            get => GetPresentationByName(Name);
            set { }
        }

        #endregion
    }
}
