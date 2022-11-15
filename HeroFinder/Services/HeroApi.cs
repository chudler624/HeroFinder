using HeroFinder.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeroFinder.Services
{
	public class HeroApi
	{
		public HeroApi() { }

		public List<HeroModel> GetHero(string hero)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://superhero-search.p.rapidapi.com/api/?hero={hero}"),
				Headers =
				{
					{ "X-RapidAPI-Key", "fe96c29976msh7164fa7f072bef1p19efc6jsn0ad83cbe2bb2" },
					{ "X-RapidAPI-Host", "superhero-search.p.rapidapi.com" },
				},
			};
			using (var response = client.SendAsync(request).Result)
			{
				response.EnsureSuccessStatusCode();
				var body = response.Content.ReadAsStringAsync().Result;

				var item = JsonConvert.DeserializeObject<HeroQualities>(body);

				var heroModel = new List<HeroModel>();

				
				
					heroModel.Add(new HeroModel
					{
						Name = item.name,
						Image = item.images.sm,
						//appearance
						Gender = item.appearance.gender,
						Race = item.appearance.race,
						Height = item.appearance.height,
						Weight = item.appearance.weight,
						EyeColor = item.appearance.eyeColor,
						HairColor = item.appearance.hairColor,
						//biography
						FullName = item.biography.fullName,
						AlterEgos = item.biography.alterEgos,
						Aliases = item.biography.aliases,
						PlaceOfBirth = item.biography.placeOfBirth,
						FirstAppearance = item.biography.firstAppearance,
						Publisher = item.biography.publisher,
						Alignment = item.biography.alignment,
						//powerstats
						Combat = item.powerstats.combat,
						Durability = item.powerstats.durability,
						Inteligence = item.powerstats.intelligence,
						Power = item.powerstats.power,
						Speed = item.powerstats.speed,
						Strength = item.powerstats.speed,
						//work
						Occupation = item.work.occupation,
						//Connections
						Relatives = item.connections.relatives,
						GroupAffiliation = item.connections.groupAffiliation,


					}) ;


				

					return heroModel;
			}

		}
	}
}
                    

                




			


		

    

