namespace TestAutoMapper.Dtos
{

    //Dto Model
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool? isFree { get; set; }
    }
}
