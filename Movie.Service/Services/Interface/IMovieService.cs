using Movie.Data.Model.CommonModel;
using Movie.Data.Model.DatabaseModel;
using Movie.Data.Model.ResultModel;

namespace Movie.Service.Services.Interface
{
    public interface IMovieService
    {
        MoviesListResult GetMoviesList(TableModel model);
        
        TblMovie GetMovieById(int id);

        List<TblMovie> GetSimilarMoviesList(int typeId); 
    }
}
