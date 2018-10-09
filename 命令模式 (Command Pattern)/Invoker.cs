using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式__Command_Pattern_
{
    class Invoker
    {
        private IList<Command> cmds = new List<Command>();

        public void SetCommand(Command command)
        {
            cmds.Add(command);
        }

        public void Run()
        {
            foreach (var item in cmds)
            {
                item.Execute();
            }
        }

    }
}
