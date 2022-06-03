using Figgle;

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine(
    FiggleFonts.Standard.Render("Obrigado!"));

Console.BackgroundColor = ConsoleColor.DarkBlue;

Console.WriteLine(
    FiggleFonts.Big.Render("Java"));

Console.ResetColor();

Console.WriteLine("Pressione uma tecla para finalizar...");

Console.ReadKey();