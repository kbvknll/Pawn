// See https://aka.ms/new-console-template for more information
using Pawn.Core;

Console.WriteLine("Hello, World!");
Figure f = new Figure(2, 3);
Pawn1 pawn = new Pawn1(3, 2);
Console.WriteLine(pawn.Move(3, 2));
king king = new king(1, 2);
Console.WriteLine(king.Move(4,2));
Rook rook = new Rook(4, 5); 
Console.WriteLine(rook.Move(4, 5));
Queen queen = new Queen(1, 1);
Console.WriteLine(queen.Move(1, 1));
Horse horse = new Horse(7, 8);
Console.WriteLine(horse.Move(7, 8));
Elephant elephant = new Elephant(2, 4);   
Console.WriteLine(elephant.Move(2, 4));