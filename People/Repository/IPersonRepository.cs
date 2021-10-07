using System.Collections.Generic;
using People.Data.VO;
using People.Models;
using People.Repository.Generic;

namespace People.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string lastName);
    }
}
