using PubSubPattern.Events;
using PubSubPattern.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubPattern.Subscribers;
public class GameSubscriber
{
    public void Subscribe(GamePublisher gamePublisher)
    {
        gamePublisher.PublishedEvent += Update;
        
    }


    public void Update(Object sender, EventArguments e)
    {
        GamePublisher pub = (GamePublisher) sender;
        Console.WriteLine($"{pub.Name} published the message {e.Message}");
    }
}
