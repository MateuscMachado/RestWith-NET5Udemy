using System.Collections.Generic;
using People.Data.VO;
using People.Models;

namespace People.Business
{
   public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}