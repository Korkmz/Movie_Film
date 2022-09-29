using Microsoft.AspNetCore.Mvc;
using Movie.Data.Access.Context;
using Movie.Data.Model.CommonModel;
using Movie.Data.Model.ResultModel;
using Movie.Service.Services.Interface;
using Movie.UI.Models;
using System.Diagnostics;
using X.PagedList;

namespace Movie.UI.Controllers
{
    public class MovieController : Controller
    {
        private IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var detail = _movieService.GetMovieById(id);

            var simalarMovies = _movieService.GetSimilarMoviesList(detail.TblMovieTypeId);
            MovieDetailResultModel model = new();
            model.Detail = detail;
            model.SimilarMovies = simalarMovies;

            return View(model);
        }



        [HttpPost]
        public IActionResult GetMovie(TableModel model)
        {
            model.PageSize = 9;
            var result = _movieService.GetMoviesList(model);

            return Json(new
            {
                data =result
            });

        }

    }
}
