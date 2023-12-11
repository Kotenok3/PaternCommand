namespace PaternCommand;

public class FillCommand : ICommand
{
    private Figure _figure;

    public FillCommand(Figure figure)
    {
        _figure = figure;
    }

    public void Execute()
    {
        _figure.SetFilled();
    }

    public void Undo()
    {
        _figure.SetUnFilled();
    }
}