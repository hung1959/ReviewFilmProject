using System.Collections.Generic;

namespace FilmProject.DataCore
{
    public interface IFilmContainer
    {
        IList<object> FetchAll();
    }
}
