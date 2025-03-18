// See https://aka.ms/new-console-template for more information

// Elora Smith, 3/18/25, Lab 7 Maze

Console.WriteLine("Welcome to the MAZE! Use the arrows to navigate to the star at the end. Press enter to start.");
if (Console.ReadKey(true).Key == ConsoleKey.Enter)
{
    Console.Clear();
    string[] mapRows = File.ReadAllLines("map.txt");
    foreach (string row in mapRows)
    Console.WriteLine(row);
}



