using Core.Library.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary.Users
{
    public interface User
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IEnumerable<Character> Characters { get; set; }
    }
}
