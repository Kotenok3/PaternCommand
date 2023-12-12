using PaternCommand;

var figure = new Figure(5);

var crCommand = new CreateCommand(figure);
var DelCommand = new DeleteCommand(figure);
var FillCommand = new FillCommand(figure);

Stack<ICommand> historyCommands = new Stack<ICommand>();

//Создаем фигуру
crCommand.Execute();
historyCommands.Push(crCommand);

//Удаляем фигуру
DelCommand.Execute();
historyCommands.Push(DelCommand);

//Меняем заливку у фигуры
FillCommand.Execute();
historyCommands.Push(FillCommand);

//Создаем фигуру
crCommand.Execute();
historyCommands.Push(crCommand);

//Отменяем последнюю комманду
var com = historyCommands.Pop();
com.Undo();

//Создаем снова заполненую фигуру
crCommand.Execute();
historyCommands.Push(crCommand);
