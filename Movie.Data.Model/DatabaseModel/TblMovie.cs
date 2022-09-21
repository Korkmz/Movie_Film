using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Data.Model.DatabaseModel
{
    public class TblMovie : BaseEntity
    {
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? Score { get; set; }
        public string? Description { get; set; }
        public TblMovieType TblMovieType { get; set; }
        public int TblMovieTypeId { get; set; }
        public DateTime Date { get; set; }
        public TblGeneralAudienceType TblGeneralAudienceType { get; set; }
        public int TblGeneralAudienceTypeId { get; set; }
    }
}
