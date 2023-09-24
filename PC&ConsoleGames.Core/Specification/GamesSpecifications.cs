using Ardalis.Specification;
using PC_ConsoleGames.Core.Entities;


namespace PC_ConsoleGames.Core.Specification
{
    public static class GamesSpecifications
    {
        public class OrderByAll : Specification<Game>
        {
            public OrderByAll()
            {
                Query
                    .OrderBy(c => c.Name)
                    .Include(c => c.Genres)
                    .ThenInclude(c => c._Genre)
                    .Include(c => c.Languages)
                    .ThenInclude(c => c._Language);
            }
        }
        public class OrderByAllByID : Specification<Game>
        {
            public OrderByAllByID()
            {
                Query
                    .OrderBy(c => c.Id)
                    .Include(c => c.Genres)
                    .ThenInclude(c => c._Genre)
                    .Include(c => c.Languages)
                    .ThenInclude(c => c._Language);
            }
        }
        public class ByID : Specification<Game>
        {
            public ByID(int ID)
            {
                Query
                    .Include(c => c.Genres)
                    .ThenInclude(c => c._Genre)
                    .Include(c => c.Languages)
                    .ThenInclude(c => c._Language)
                    .Where(c => c.Id == ID);
            }
        }
        public class ByYear : Specification<Game>
        {
            public ByYear()
            {
                Query
                    .Include(c => c.Genres)
                    .ThenInclude(c => c._Genre)
                    .Include(c => c.Languages)
                    .ThenInclude(c => c._Language)
                    .OrderBy(c => c.ReleaseDate);
            }
        }
        public class ByYearDescending : Specification<Game>
        {
            public ByYearDescending()
            {
                Query
                    .Include(c => c.Genres)
                    .ThenInclude(c => c._Genre)
                    .Include(c => c.Languages)
                    .ThenInclude(c => c._Language)
                    .OrderByDescending(c => c.ReleaseDate);
            }
        }
    }
}
