namespace PaternCommand;

public static class ConsoleExtensions
{
    public static void ClearLines(int lines)
    {
        lines++;
        for (int i = 0; i < lines; i++)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }

    public static void DrawFigure(Figure figure)
    {
        var size = figure.Size;
        
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (figure.IsFilled)
                {
                    Console.Write("*");
                }
                else
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}