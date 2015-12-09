using System;

namespace SmartHome.Core.Interfaces
{
    public interface ICommand<TResult>
    {
        event EventHandler CanExecuteChanged;
        bool CanExecute(dynamic parameter);
        dynamic Data { get; set; }
        TResult Execute();
    }
}
