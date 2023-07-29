using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubPattern.Events;

public class EventArguments : EventArgs
{
    public EventArguments(string message)
    {
        Message = message;
    }
    public string Message { get; set; }

}
