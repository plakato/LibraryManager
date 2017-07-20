﻿using Shaolinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Copy : DataAccessObject
    {
        internal const string FREE = "Voľná";
        internal const string LOANED = "Požičaná";
        [PrimaryKey]
        [AutoIncrement]
        [PersistedMember]
        public abstract int ID { get; set; }

        [PrimaryKey]
        [BackReference]
        public abstract Book Book { get; set; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Loan> Loans { get; }

        public string GetStatus()
        {
            if (Loans.Where(loan => loan.Active == true).Any())
            {
                return LOANED;
            } else
            {
                return FREE;
            }
        }
    }
}
