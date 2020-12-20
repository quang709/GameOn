using System;
using System.Collections.Generic;
using System.Text;

namespace GO.Domain.Response.Games
{
    public class Games
    {
        public int IdGame { get; set; }
        public string GameName { get; set; }
        public string Gameplay { get; set; }
        public string Conclusion { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public float Graphics { get; set; }
        public float Levels { get; set; }
        public float Dificulty { get; set; }
        public string Testimonials { get; set; }
        public int IdCategory { get; set; }
    }
}
