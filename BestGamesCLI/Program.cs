using BestGamesCLI;

Random rnd = new();
List<Game> games = new();

using StreamReader sr = new("..\\..\\..\\src\\bestgames.csv");
while (!sr.EndOfStream) games.Add(new(sr.ReadLine()!));

Console.WriteLine($"f1: osszesen {games.Count} jatek szerepel a listaban");

var f2 = games.GroupBy(g => g.Year).Where(grp => grp.Count() > 10).OrderBy(grp => grp.Key);
Console.WriteLine("f2: ezekben az evekben kerult tobb, mint 10 jatek a listara:");
foreach (var grp in f2) Console.WriteLine($"\t{grp.Key}: {grp.Count()}db");

var f3 = games.Where(g => g.Genre == "First-person shooter").ToArray();
Console.WriteLine($"f3: osszesen {f3.Length} FPS kerult fel a listara");
Console.WriteLine($"\tpeldaul a(z): {f3[rnd.Next(f3.Length)].Title}");