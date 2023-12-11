using PaternCommand;

var figure = new Figure(5);

var crCommand = new CreateCommand(figure);
var DelCommand = new DeleteCommand(figure);
var FillCommand = new FillCommand(figure);

Stack<ICommand> commands = new Stack<ICommand>();

//Создаем фигуру
crCommand.Execute();
commands.Push(crCommand);

//Удаляем фигуру
DelCommand.Execute();
commands.Push(DelCommand);

//Меняем заливку у фигуры
FillCommand.Execute();
commands.Push(FillCommand);

//Создаем фигуру
crCommand.Execute();
commands.Push(crCommand);

//Отменяем последнюю комманду
var com = commands.Pop();
com.Undo();

//Создаем снова заполненую фигуру
crCommand.Execute();
commands.Push(crCommand);
