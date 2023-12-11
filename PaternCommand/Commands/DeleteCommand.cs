namespace PaternCommand;

public class DeleteCommand: ICommand
{
    private Figure _figure;

    public DeleteCommand(Figure figure)
    {
        _figure = figure;
    }

    public void Execute()
    {
        ConsoleExtensions.ClearLines(_figure.Size);
    }

    public void Undo()
    {
        ConsoleExtensions.DrawFigure(_figure);
    }
}