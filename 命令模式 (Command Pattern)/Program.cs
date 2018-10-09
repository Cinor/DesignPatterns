using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式__Command_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            ReceiverRobot robot = new ReceiverRobot();

            GoAheadCommand cmd_goAhead = new GoAheadCommand(robot);
            TurnLeftCommand cmd_turnLeft = new TurnLeftCommand(robot);
            TurnRightCommand cmd_turnRight = new TurnRightCommand(robot);


            invoker.SetCommand(cmd_goAhead);
            invoker.SetCommand(cmd_goAhead);
            invoker.SetCommand(cmd_turnLeft);
            invoker.SetCommand(cmd_turnRight);
            invoker.SetCommand(cmd_turnLeft);
            invoker.SetCommand(cmd_goAhead);
            invoker.SetCommand(cmd_turnLeft);

            invoker.Run();

            Console.ReadLine();
        }
    }
}
