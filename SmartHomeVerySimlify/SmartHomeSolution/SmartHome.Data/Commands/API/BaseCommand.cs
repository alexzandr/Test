using System;
using SmartHome.Core.Interfaces;

namespace SmartHome.Core.Commands.API
{
    public abstract class BaseCommand<TResult> : ICommand<TResult>
    {
        public event EventHandler CanExecuteChanged;
        public virtual bool CanExecute(dynamic parameter = null)
        {
            return true;
        }

        public virtual dynamic Data { get; set; }
        public abstract TResult Execute();
    }
}
