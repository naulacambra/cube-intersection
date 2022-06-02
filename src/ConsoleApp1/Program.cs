// See https://aka.ms/new-console-template for more information
using CubeIntersection.Application.Services;
using CubeIntersection.Core.Entities;

Console.WriteLine("Cube instersection");
Console.WriteLine("1st body");
Console.Write("Position (x, y, z): ");
var positionBody1 = Console.ReadLine();
Console.Write("Size (w [, h [, d]]): ");
var sizeBody1 = Console.ReadLine();

Console.WriteLine("2nd body");
Console.Write("Position (x, y, z): ");
var positionBody2 = Console.ReadLine();
Console.Write("Size (w [, h, d]): ");
var sizeBody2 = Console.ReadLine();

var body1 = new Cube(positionBody1, sizeBody1);
var body2 = new Cube(positionBody2, sizeBody2);

Console.WriteLine(body1.ToString());
Console.WriteLine(body2.ToString());

var collider = new TwoBodyCollider(body1, body2);
Console.WriteLine("The bodies collide?: {0}", collider.Collides());
Console.WriteLine("Intersection volume: {0}u cubics", collider.Intersection());