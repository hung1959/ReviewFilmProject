using System.Collections.Generic;

namespace FilmProject.Core
{
    public interface IFilmContainer
    {
        IList<object> FetchAll();
    }
}
