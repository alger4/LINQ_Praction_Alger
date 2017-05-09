<Query Kind="Statements">
  <Connection>
    <ID>ffa85d83-a221-4649-a35f-a47f2d55e6be</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results=from g in Genres
			orderby g.Name
			select new {
			Genre =g.Name,
			TracksCount=g.Tracks.Count()
			};
			results.Dump("Heavy Metal");