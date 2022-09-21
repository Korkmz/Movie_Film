using Movie.Data.Model.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Data.Model.ResultModel
{
    public class MovieDetailResultModel
    {
        public TblMovie Detail { get; set; }
        public List<TblMovie> SimilarMovies { get; set; }
    }
}
