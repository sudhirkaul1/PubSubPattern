using PubSubPattern.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubPattern.Publishers;
public class GamePublisher : IPublisher , IMessageBroker
{
    
    public string Name { get; set; }

    public event EventHandler<EventArguments> PublishedEvent;

    public void Publish(string message)
    {
        EventArguments args = new EventArguments(message);
        if (PublishedEvent != null)
            PublishedEvent(this, args);

    }

}
