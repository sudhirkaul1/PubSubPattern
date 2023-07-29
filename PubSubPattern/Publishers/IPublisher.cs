namespace PubSubPattern.Publishers
{
    public interface IPublisher
    {
        void Publish(string message);
    }
}