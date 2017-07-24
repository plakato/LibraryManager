using Shaolinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Book : DataAccessObject
    {
        [PrimaryKey]
        [PersistedMember]
        public abstract string ISBN { get; set; }

        [PersistedMember]
        public abstract string Title { get; set; }

        [PersistedMember]
        public abstract string Author { get; set; }

        [PersistedMember]
        public abstract int NumberOfPages { get; set; }

        [PersistedMember]
        public abstract string Section { get; set; }

        [PersistedMember]
        public abstract int PublicationYear { get; set; }

        [PersistedMember]
        public abstract string Publisher { get; set; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Category_Book> Category_Books { get; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Copy> Copies { get; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Keyword_Book> Keyword_Books { get; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Reservation> Reservations { get; }

        internal string GetStatus()
        {
            int onLoan = 0;
            int reserved = 0;
            int free = 0;
            int copies = Copies.Count();

            foreach (Copy copy in Copies)
            {
                if (copy.Loans.Where(loan => loan.Active == true).Any())
                {
                    onLoan++;
                }
                else
                {
                    free++;
                }
            }
            reserved = Reservations.Where(res => res.Active == true).Count();

            if (onLoan >= copies)
            {
                return $"Požičaná({onLoan}/{copies})";
            }
            else 
            {
                return $"Voľná({copies-onLoan}/{copies})"+(reserved==0?"":$"Rezervácií:{reserved}");
            }

        }
        internal IQueryable<string> GetKeywords()
        {
            return Keyword_Books.Select(kb => kb.Keyword.Word);
        }
    }
}
