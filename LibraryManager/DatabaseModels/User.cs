using Shaolinq;
using System;

namespace LibraryManager.DatabaseModels
{
    /// <summary>
    /// Table containg users, their logins, passwords and admin rights.
    /// </summary>
    [DataAccessObject]
    public abstract class User : DataAccessObject
    {
        [PersistedMember]
        public abstract string Name { get; set; }

        [PersistedMember]
        public abstract string Login { get; set; }

        [PersistedMember]
        public abstract string Password { get; set; }

        [PersistedMember]
        public abstract bool Admin { get; set; }
    }
}
