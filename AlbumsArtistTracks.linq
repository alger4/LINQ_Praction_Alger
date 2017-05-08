<Query Kind="Statements">
  <Connection>
    <ID>ee1b0671-5511-49a4-884e-ae2f358ddab7</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
			where x.ArtistId==1
 			orderby x.Name  select new{
									  Artist= x.Name,
									  Albums= from t in x.Albums
									  orderby t.Title
									  select new{
									  Title=t.Title,
									  Tacks=from tr in t.Tracks 
									  			select new {
												TrackName=tr.Name,
												GenreId=tr.GenreId,
												Composer=tr.Composer,
												Milliseconds=tr.Milliseconds
												}
									  }
									  };
									  results.Dump();