using SpotifyApp.Entities;
using SpotifyApp.Services;

Console.WriteLine("Spotify App");

var song1 = new Song("Fur Elise", "Ludwig van Beethoven", "Ludwig van Beethoven", "Ludwig van Beethoven");
var song2 = new Song("Smells Like Teen Spirit", "Nirvana", "Butch Vig", "Kurt Cobain, Krist Novoselic, Dave Grohl");
var song3 = new Song("Summertime Sadness", "Lana Del Rey", "Rick Nowels", "Lana Del Rey, Rick Nowels");
var song4 = new Song("Eine kleine Nachtmusik", "Wolfgang Amadeus Mozart", "Wolfgang Amadeus Mozart", "Wolfgang Amadeus Mozart");
var song5 = new Song("Nocturne in E-flat Major, Op. 9, No. 2", "Frédéric Chopin", "Frédéric Chopin", "Frédéric Chopin");

var playList1 = new Playlist(song1);
playList1.AddSong(song2);
playList1.AddSong(song3);
playList1.AddSong(song4);
playList1.AddSong(song5);

Console.WriteLine("\nBefore Shuffle");
Console.WriteLine(playList1.GetSong());

playList1.ShuffleSongs();
Console.WriteLine("\n\nAfter Shuffle");
Console.WriteLine(playList1.GetSong());

NotepadService notepadService = new();
notepadService.WriteToNotepad(playList1);
