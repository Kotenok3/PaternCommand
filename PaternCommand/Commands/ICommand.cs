namespace PaternCommand;

public interface ICommand
{
    void Execute();
    void Undo();
}