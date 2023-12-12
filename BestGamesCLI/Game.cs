namespace BestGamesCLI
{
    internal class Game
    {
        public int Year { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Publisher { get; set; }
        public string[] Platforms { get; set; }

        public override string ToString()
        {
            return $"[{Year};{Title};{Genre};{Publisher};{string.Join(", ", Platforms)}]";
        }

        public Game(string dataRow)
        {
            string[] members = dataRow.Split(';');
            Year = int.Parse(members[0]);
            Title = members[1];
            Genre = members[2];
            Publisher = members[3];
            Platforms = members[4].Split(", ");
        }
    }
}
