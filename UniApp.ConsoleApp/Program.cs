using Microsoft.EntityFrameworkCore;
using UniApp.Core;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

var ctx = new UniDbContext();

foreach(var f in ctx.Faculties.Include(x=> x.Cathedras))
{
    Console.WriteLine($"F: {f.Title}");
    foreach(var c in f.Cathedras)
    {
        Console.WriteLine($"\t\tC:{c.Title}");
    }
}

Console.WriteLine();


