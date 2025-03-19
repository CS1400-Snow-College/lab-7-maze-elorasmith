// See https://aka.ms/new-console-template for more information

// Elora Smith, 3/18/25, Lab 7 Maze
using System.Data;

Console.Clear();
Console.WriteLine("Welcome to the MAZE! Use the arrows to navigate to the star at the end. Press enter to start.");
string [] mapRows = File.ReadAllLines("map.txt");
if (Console.ReadKey(true).Key == ConsoleKey.Enter)
{
    Console.Clear();
    foreach (string row in mapRows)
    Console.WriteLine(row);
}

ConsoleKey key;
int x = 0;
int y = 0;
//int cursorLeft = 0;
//int cursorTop = 0;
Console.SetCursorPosition(0,0);
do
{
    
    key = Console.ReadKey(false).Key;
    if (key==ConsoleKey.LeftArrow)
        x--;
    else if (key==ConsoleKey.RightArrow)
       x++;
    else if (key==ConsoleKey.UpArrow)
        y--;
    else if (key==ConsoleKey.DownArrow)
        y++;

    if (x >= 0 && x < Console.BufferHeight && y >= 0 && y < Console.BufferHeight)
    Console.SetCursorPosition(x, y); 
    else if (x < 0)
        x = 0;
    else if (y < 0)
        y = 0;

    if (mapRows[Console.CursorTop][Console.CursorLeft]=='*')
    {
        Console.Clear();
        Console.WriteLine("Congrats, you got through the Maze! Press Enter to end.");
        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        break;
    }
    
}
while (key != ConsoleKey.Escape);
Console.Clear();

/*
void TryMove (int proposedTop, int proposedLeft)
{
    if (proposedLeft > 0 && proposedLeft < Console.BufferHeight && proposedTop > 0 && proposedTop < Console.BufferHeight)
    {
        cursorLeft = proposedLeft;
        cursorTop = proposedTop;
    }
}
*/