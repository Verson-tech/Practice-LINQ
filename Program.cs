using System.Security.Cryptography.X509Certificates;

var gameList = new List<string> { "Tank",
                                "Super Mario",
                                "Battletoads",
                                "Tetris",
                                "Mermaid",
                                "Adventure Island",
                                "Sonic Riders" };
gameList.OrderByDescending(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
gameList.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine("--------------------------------------");
Console.WriteLine(".Where");
gameList.Where(x => x.Length <= 6).ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine("--------------------------------------");
Console.WriteLine(".Select");
var result = gameList.Select(game => game.Length).ToList();
result.ForEach(x => Console.WriteLine(x));




























//gameList.Count();


