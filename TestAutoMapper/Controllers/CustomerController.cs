using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAutoMapper.Dtos;
using TestAutoMapper.Models;

namespace TestAutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CLSDBContext db;
        private readonly IMapper mapper;

        public CustomerController(CLSDBContext db,IMapper mapper) 
        {
            this.db = db;
            this.mapper = mapper;
        }



        [HttpGet]
        public IActionResult Get()
        {
            var books = db.Books.ToList();
            var bookDtos=mapper.Map<IEnumerable<BookDto>>(books);
            return Ok(bookDtos);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = db.Books.Find(id);
            var bookDto = mapper.Map<BookDto>(book);
            return Ok(bookDto);

        }






        [HttpPost]
        public IActionResult Post(BookDto bookDto)
        {
            Book book = new Book();
            book = mapper.Map<Book>(bookDto);
            db.Books.Add(book);
            db.SaveChanges();
            return Ok(book);
        }
    }
}
