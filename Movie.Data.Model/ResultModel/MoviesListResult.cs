using Movie.Data.Model.DatabaseModel;

namespace Movie.Data.Model.ResultModel
{
    public class MoviesListResult
    {
        public IQueryable<TblMovie>? List { get; set; }
        public int PageSize { get; set; } = 10;
        public int PageCount { get; set; } 
        public int CurrentPage { get; set; }
        public int RowCount { get; set; }
    }
}
