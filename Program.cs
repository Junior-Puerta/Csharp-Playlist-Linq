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
foreach (var song in songs1991)
    Console.WriteLine(song);

