using Microsoft.EntityFrameworkCore;
using Movie.Data.Access.Context;
using Movie.Data.Model.CommonModel;
using Movie.Data.Model.DatabaseModel;
using Movie.Data.Model.ResultModel;
using Movie.Service.Services.Interface;

namespace Movie.Service.Services
{
    public class MovieService : IMovieService
    {
        public MovieDbContext _movieDbContext;
        public MovieService(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public TblMovie GetMovieById(int id)
        {
            var detail = _movieDbContext.TblMovie.Include(p=>p.TblMovieType).Include(p=>p.TblGeneralAudienceType).Where(p => p.Id == id)?.FirstOrDefault();
            return detail;
        }

        public MoviesListResult GetMoviesList(TableModel model)
        {
            MoviesListResult result = new();

            IQueryable<TblMovie> movieList = _movieDbContext.TblMovie ;

            if (!String.IsNullOrEmpty(model.Search))
            {
                movieList= movieList.Where(p=>p.Name.ToLower().Contains(model.Search.ToLower()));  
            }

            result.PageCount = movieList.Count();
            result.CurrentPage = model.CurrentPage;
            result.RowCount=(int)Math.Ceiling((decimal)movieList.Count()/model.PageSize);

            var skip = 0;
            if(model.CurrentPage!=0)
                skip=(model.CurrentPage - 1) * model.PageSize;

            result.List = movieList.Skip(skip)
                .Take(model.PageSize );


            return result;
        }

        public List<TblMovie> GetSimilarMoviesList(int typeId)
        {
            var list = _movieDbContext.TblMovie.Where(p => p.TblMovieTypeId == typeId).ToList();
            return list;
        }
    }
}
