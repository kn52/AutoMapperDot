namespace AutoMapperSln.Automapper
{
    using AutoMapper;
    using System;
    public class AuthorDemo
    {
        public static void SMapper()
        {
            Console.WriteLine("=====Similar Type=====");
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Author, AuthorSimilarDTO>();
            });
            IMapper iMapper = config.CreateMapper();
            var author = GetAuthor();
            var authorDTO = iMapper.Map<Author, AuthorSimilarDTO>(author);
            Console.WriteLine("Author Name: " + authorDTO.FirstName + " " + authorDTO.LastName);
        }

        public static void DMapper()
        {
            Console.WriteLine("=====Dissimilar Type=====");
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Author, AuthorDissimilarDTO>()
                .ForMember(dest => dest.FName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Addr, opt => opt.MapFrom(src => src.Address));
            });
            IMapper iMapper = config.CreateMapper();
            var author = GetAuthor(); 
            var authorDTO = iMapper.Map<Author, AuthorDissimilarDTO>(author);
            Console.WriteLine("Author Name: " + authorDTO.FName + " " + authorDTO.LName);
        }

        public static void CMapper()
        {
            Console.WriteLine("=====Conditional=====");
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Author, AuthorSimilarDTO>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => (src.FirstName != null)));
            });
            IMapper iMapper = config.CreateMapper();
            var author = GetAuthor();
            var authorDTO = iMapper.Map<Author, AuthorDissimilarDTO>(author);
            Console.WriteLine("Author Name: " + authorDTO.FName + " " + authorDTO.LName);
        }

        private static Author GetAuthor()
        {
            return new Author
            {
                Id = 1,
                FirstName = "Stephen",
                LastName = "Hawking",
                Address = "United Kingdom",
            };
        }
    }
}
