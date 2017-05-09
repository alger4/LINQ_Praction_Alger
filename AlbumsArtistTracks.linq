<Query Kind="Statements">
  <Connection>
    <ID>ffa85d83-a221-4649-a35f-a47f2d55e6be</ID>
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
												Genre=tr.Genre.Name,
												MediaType=tr.MediaType.Name,
												Composer=tr.Composer,
												Milliseconds=tr.Milliseconds
												}
									  }
									  };
									  results.Dump();