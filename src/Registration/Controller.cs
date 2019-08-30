using System;
using Infrastructure;
using Registration.Blueprint.Commands;


namespace Registration
{
    public class Controller
    {
        private ConsoleView _view;
        private readonly IBus _mainBus;

        public Controller(ConsoleView view, IBus mainBus)
        {
            _view = view;
            _mainBus = mainBus;
        }
        public void StartCommandLoop()
        {
            do //Command loop
            {
                var cmd = Console.ReadLine();
                //Single token commands
                if (cmd.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Disconnecting EventStore");
                    break;
                }
                if (cmd.Equals("list-links", StringComparison.OrdinalIgnoreCase))
                {
                    _view.ListLinks();
                    break;
                }
                if (cmd.Equals("list-history", StringComparison.OrdinalIgnoreCase))
                {
                    _view.ListHistory();
                    break;
                }
                //3 token commands
                var tokens = cmd.Split(' ');
                if (tokens.Length != 2)
                {
                    _view.ErrorMsg = "Unknown command or Invalid number of parameters.";
                    continue;
                }
                switch (tokens[0].ToUpperInvariant())
                {
                    case "Revoke":
                        // TODO id is in tokens[1]
                        // var addRoom = new AddRoom(
                        //     Guid.NewGuid(),
                        //     tokens[1],
                        //     tokens[2],
                        //     tokens[3]);
                        //
                        // _mainBus.Publish(addRoom);
                        break;
                    case "Approve":
                        // var addRoom = new AddRoom(
                        //     Guid.NewGuid(),
                        //     tokens[1],
                        //     tokens[2],
                        //     tokens[3]);
                        //
                        // _mainBus.Publish(addRoom);
                        break;
                    default:
                        _view.ErrorMsg = "Unknown Command";
                        break;
                }

            } while (true);
        }
    }
}