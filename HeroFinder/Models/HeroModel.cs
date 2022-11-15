namespace HeroFinder.Models
{
    public class HeroModel
    {
        public string Name { get; set; }
        public string Image { get; set; }

        //appearance
        public string Gender { get; set; }
        public string Race { get; set; }
        public List<string> Height { get; set; }
        public List<string> Weight { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }

        //biography
        public string FullName { get; set; }
        public string AlterEgos { get; set; }
        public List<string> Aliases { get; set; }
        public string PlaceOfBirth { get; set; }
        public string FirstAppearance { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }

        //powerstats
        public int Combat { get; set; }
        public int Durability { get; set; }
        public int Inteligence { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }

        //work
        public string Occupation { get; set; }
        public string @Base { get; set; }
        //Connections
        public string GroupAffiliation { get; set; }
        public string Relatives { get; set; }



    }
}
