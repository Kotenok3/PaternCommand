namespace PaternCommand;

public class CreateCommand : ICommand
{
    private Figure _figure;

    public CreateCommand(Figure figure)
    {
        _figure = figure;
    }

    public void Execute()
    {
        ConsoleExtensions.DrawFigure(_figure);
    }

    public void Undo()
    {
        ConsoleExtensions.ClearLines(_figure.Size);
    }
}