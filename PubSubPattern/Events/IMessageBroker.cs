namespace PubSubPattern.Events
{
    public interface IMessageBroker
    {
        event EventHandler<EventArguments> PublishedEvent;
    }
}