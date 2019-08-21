using System;


namespace Registration
{
    public class Controller
    {
        private ConsoleView _view;
        public Controller(ConsoleView view)
        {
            _view = view;
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
                //3 token commands
                var tokens = cmd.Split(' ');
                if (tokens.Length != 3)
                {
                    _view.ErrorMsg = "Unknown command or Invalid number of parameters.";
                    continue;
                }
                switch (tokens[0].ToUpperInvariant())
                {
                    case "ADD":
                        //TODO: Publish Add Command
                        break;
                    default:
                        _view.ErrorMsg = "Unknown Command";
                        break;
                }

            } while (true);
        }
    }
}