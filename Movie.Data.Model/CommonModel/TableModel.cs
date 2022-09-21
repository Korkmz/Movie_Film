using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Data.Model.CommonModel
{
    public class TableModel
    {
        public string? Search { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; } = 10; //Default 30 kayıt gelecektır.
        public int CurrentPage { get; set; }

    }
}
