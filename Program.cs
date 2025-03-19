// See https://aka.ms/new-console-template for more information

// Elora Smith, 3/18/25, Lab 7 Maze
using System.Data;
using System.Diagnostics;
using System.Net;

Console.Clear();
Console.WriteLine("Welcome to the MAZE! Use the arrows to navigate to the star at the end. Press enter to start.");
string [] mapRows = File.ReadAllLines("map.txt");
if (Console.ReadKey(true).Key == ConsoleKey.Enter)
{
    Console.Clear();
    foreach (string row in mapRows)
    Console.WriteLine(row);
}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
ConsoleKey key;
int x = 0;
int y = 0;
Console.SetCursorPosition(x, y);

do
{
    key = Console.ReadKey(false).Key;
    if (key==ConsoleKey.LeftArrow && mapRows[Console.CursorTop][Console.CursorLeft-1] != '#')
        x--;
    else if (key==ConsoleKey.RightArrow && mapRows[Console.CursorTop][Console.CursorLeft+1] != '#')
       x++;
    else if (key==ConsoleKey.UpArrow && mapRows[Console.CursorTop-1][Console.CursorLeft] != '#')
        y--;
    else if (key==ConsoleKey.DownArrow && mapRows[Console.CursorTop+1][Console.CursorLeft] != '#')
        y++;

    TryMove(x, y);
    if (x < 0)
        x = 0;
    else if (y < 0)
        y = 0;

    if (mapRows[Console.CursorTop][Console.CursorLeft]=='*')
    {
        stopwatch.Stop();
        int seconds = (int)stopwatch.ElapsedMilliseconds/1000;
        Console.Clear();
        Console.WriteLine($"Congrats, you got through the Maze! It took you {seconds} seconds. Press Enter to end.");
        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        break;
    } 
}
while (key != ConsoleKey.Escape);
Console.Clear();


void TryMove (int x, int y)
{
    if (x >= 0 && x < Console.BufferHeight && y >= 0 && y < Console.BufferHeight)
        Console.SetCursorPosition(x, y);
}
