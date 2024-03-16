
using System.ComponentModel.DataAnnotations;

public class Avtoriz
        {
            public int ID { get; set; }
            public string? Login { get; set; }
            public string? Password { get; set; }
            public string? Type { get; set; }
            public string? Name { get; set; }

            public static Avtoriz? currentUser { get; set; }
        }
        
        public class Tools
        {
            [Key]
            
            public string? Название { get; set; }
            public string? Страна производитель { get; set; }
            public string? Компания { get; set; }

            public static Tools? currentUser1 { get; set; }
        }
