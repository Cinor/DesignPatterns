using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式__Command_Pattern_
{
    // 向右轉的命令
    class TurnRightCommand : Command
    {
        public TurnRightCommand(ReceiverRobot robot) : base(robot)
        {

        }

        public override void Execute()
        {
            robot.TurnRight();
        }
    }
}
