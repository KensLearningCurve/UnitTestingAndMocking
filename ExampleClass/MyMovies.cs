using DatabaseLib;
using DatabaseLib.Entities;
using ExampleClass.Exceptions;

namespace ExampleClass
{
    public class MyMovies
    {
        private readonly IRepository<Movie> movieRepository;

        public MyMovies(IRepository<Movie> movieRepository)
        {
            this.movieRepository=movieRepository;
        }

        public IEnumerable<Movie> GetAll()
        {
            List<Movie> result = movieRepository.GetAll().ToList();

            if (result == null)
                throw new Exception("Nothing found!");

            return result;
        }

        public Movie? Get(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id cannot be zero or less.");

            return movieRepository.GetAll()?.SingleOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            Movie? toDelete = Get(id);

            if (toDelete == null)
                throw new MovieNotFoundException();

            movieRepository.Delete(toDelete);
        }

        public void Create(Movie movie)
        {
            movieRepository.Create(movie);
        }
    }
}
