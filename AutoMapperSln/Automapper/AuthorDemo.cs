namespace AutoMapperSln.Automapper
{
    using AutoMapper;
    using System;
    public class AuthorDemo
    {
        public static void AMapper()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Author, AuthorDTO>(); });
            IMapper iMapper = config.CreateMapper();
            var author = new Author
            {
                Id = 1,
                FirstName = "Stephen",
                LastName = "Hawking",
                Address = "United Kingdom"
            };
            var authorDTO = iMapper.Map<Author, AuthorDTO>(author);
            Console.WriteLine("Author Name: " + authorDTO.FirstName + " " + authorDTO.LastName);
        }    
    }
}
