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
			context.Albums.Add(new Album()
			{
				 Artist = new Artist() { Name = "Rush"},
				 Genre = new Genre() { Name = "Rock" },
				 Price = 9.99M,
				 Title = "Caravan"
			});

			base.Seed(context);
		}
	}
}
