using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式__Command_Pattern_
{
    // 向左轉的命令
    class TurnLeftCommand : Command
    {
        public TurnLeftCommand(ReceiverRobot robot) : base(robot)
        {

        }

        public override void Execute()
        {
            robot.TurnLeft();
        }
    }
}
