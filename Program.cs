using System.Diagnostics;
using System.Reflection;
using Maxine.RustBindGen;

if (args.Length < 1)
{
    Console.WriteLine($"Usage:\n\t{Process.GetCurrentProcess().ProcessName} <assembly-path>");
}

Console.WriteLine(RustBindGen.GenerateRustBindings(Assembly.LoadFile(args[0])));