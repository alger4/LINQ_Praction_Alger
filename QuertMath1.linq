<Query Kind="Statements">
  <Connection>
    <ID>ffa85d83-a221-4649-a35f-a47f2d55e6be</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results= from g in Genres
			 where g.Name.Equals("Heavy Metal")
			 select new {
			 Tracks =from t in g.Tracks
			 	select new{
				TrackName=t.Name,
				AlbumId=t.Album.AlbumId,
				MediaType=t.MediaType.MediaTypeId,
				AlbumName=t.Album.Title,
				GenreId=t.Genre.GenreId,
				Milliseconds=t.Milliseconds,
				Size=(t.Bytes/1000)+" kb",
				Price=t.UnitPrice
				}
			 };
			 results.Dump("More Math");