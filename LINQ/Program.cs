//using C34PracticeLinqExersize;




List<string> videoGameNames = new List<string>() { "Call of Duty", "Cyberpunk", "SpongeBob for the X Box" };

videoGameNames.Add("Shrek the third");
videoGameNames.Add("Chicken Little");


var orderedVideoGames = videoGameNames.OrderBy(name => name.Length);

foreach (var videoGame in orderedVideoGames)
{
    Console.WriteLine(videoGame);
}
