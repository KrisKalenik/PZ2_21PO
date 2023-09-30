using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz0920_WPF_Logger.DebugUtilities
{
    internal class CustomException: Exception
    {
        public DateTime TimeStamp { get; } = DateTime.Now;

        public string Description { get; private set; }

        public override string HelpLink { get; set; } = "https://addres";

        public CustomException(string message): base(message)
        {
            Logger.Error($"Custom Exception: {message}");
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
            Logger.Error($"Custom Exception: {message} \n\tInner Exception: {innerException}");
        }

        public CustomException(string message, string description) : base(message)
        {
            Description = description;
            Source = "CustomException";
            Logger.Error($"Custom Exception from \"{Source}\" at {TimeStamp}: {message} [{Description}] for more information review {HelpLink}");
        }
    }
}
