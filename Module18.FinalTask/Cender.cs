using System;
using System.Collections.Generic;
using System.Text;

namespace Module18.FinalTask
{
    /// <summary>
    /// Отправитель команды
    /// </summary>

    class Sender
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        // Выполнить
        public void Download()
        {
            command.Cancel();
        }

        public void GetInfo()
        {
            command.Run();
        }

    }
}