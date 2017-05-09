<Query Kind="Statements">
  <Connection>
    <ID>ffa85d83-a221-4649-a35f-a47f2d55e6be</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results= from g in MediaTypes
			 select new{
			 Name=g.Name,
			 Tracks= from t in g.Tracks
			 		select new {
					TrackName=t.Name,
					Album=t.Album.Title,
					Artist=t.Album.Artist.Name,
					Genre=t.Genre.Name,
					ReleaseYear =t.Album.ReleaseYear,
					ReleaseLabel=t.Album.ReleaseLabel
					}
			 };
			 	results.Dump();