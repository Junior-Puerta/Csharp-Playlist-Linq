using Exercise;

Console.Clear();

var songs = new List<Songs>
{
new(1,"Bohemian Rhapsody", "Queen", new DateTime(1975,10,31) ),
new(2,"Newborn Me", "Angra", new DateTime(2014,12,17) ),
new(3,"November Rain", "Guns N' Roses", new DateTime(1991,02,18) ),
new(4,"The Show Must Go on", "Queen", new DateTime(1991,10,14) ),
};

Console.WriteLine("-- Playlist --");
for (int i = 0; i < 4; i++)
    Console.WriteLine(songs[i]);

Console.WriteLine("Songs released in 1991");
var songs1991 = songs
.Where(x => x.ReleaseDate.Year == 1991)
.ToList();

foreach (var item in songs1991)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Songs released on October");
var songsOnOctober = songs
.Where(x => x.ReleaseDate.Month == 10)
.ToList();

foreach (var item in songsOnOctober) 
Console.WriteLine(item.ToString());

Console.WriteLine("Return songs released on October");
var songsOrder = songs
.OrderBy(x => x.Name)
.ToList();

foreach (var item in songsOrder)
    Console.WriteLine(item.ToString());

Console.WriteLine("Last two songs registered in alphabetical order");
var lastTwoSongs = songs
.OrderByDescending(x => x.Id)
.Take(2)
.OrderBy(x => x.Name)
.ToList();

foreach (var item in lastTwoSongs)
    Console.WriteLine(item.ToString());