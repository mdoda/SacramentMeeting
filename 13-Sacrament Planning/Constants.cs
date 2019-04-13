using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace _13_Sacrament_Planning
{
    public class Constants
    {
        public static readonly IList<String> BishopricRoles = new ReadOnlyCollection<string>
                               (new List<String> {
                                   "Bishop",
                                   "1st Counselor",
                                   "2nd Counselor"
                               });

    }
}
