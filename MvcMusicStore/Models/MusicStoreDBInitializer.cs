using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
	public class MusicStoreDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
	{
		protected override void Seed(MusicStoreDB context)
		{
			context.Artists.Add(new Artist() { Name = "Al Di Meola" });
			context.Genres.Add(new Genre() { Name = "Jazz" });
			context.Albums.AddRange(new[] 
			{
				new Album()
				{
					 Artist = new Artist() { Name = "Rush"},
					 Genre = new Genre() { Name = "Rock" },
					 Price = 9.99M,
					 Title = "Caravan"
				},
				new Album()
				{
					Artist = new Artist() { Name = "Faith No More" },
					Genre = new Genre() { Name = "Metal" },
					Price = 9.99M,
					Title = "Angel Dust"
				}
			});

			base.Seed(context);
		}
	}
}
