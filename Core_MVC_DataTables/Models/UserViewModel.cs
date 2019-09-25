using JqueryDataTables.ServerSide.AspNetCoreWeb;
using System;

namespace Core_MVC_DataTables.Models
{
    public class UserViewModel
    {
        [SearchableString]
        [Sortable]
        public DateTime Created { get; set; }

        [SearchableString]
        [Sortable]
        public int Id { get; set; }

        [SearchableString]
        [Sortable]
        public bool IsActive { get; set; }

        [SearchableString]
        [Sortable(Default = true)]
        public string Name { get; set; }

        [SearchableString]
        [Sortable]
        public int Number { get; set; }
    }
}
