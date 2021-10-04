using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using People.Data.VO;
using People.Data.VO.Converter.Contract;
using People.Models;

namespace People.Data.Converter.Implementations
{
    public class BookConverter : IParser<Book, BookVO>, IParser<BookVO, Book>
    {
        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;

            return new BookVO
            {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;

            return new Book
            {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }
        
        public List<BookVO> Parse(List<Book> origin)
        {
            if(origin == null) return null;
            return origin.Select(item => Parse(item)).ToList(); 
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if(origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}