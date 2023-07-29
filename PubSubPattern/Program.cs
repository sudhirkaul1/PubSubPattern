// See https://aka.ms/new-console-template for more information
using PubSubPattern.Publishers;
using PubSubPattern.Subscribers;

Console.WriteLine("Hello, World!");

GamePublisher publisher = new GamePublisher();
publisher.Name = "GamePublisher";


GameSubscriber subscriber = new GameSubscriber();
subscriber.Subscribe(publisher);


publisher.Publish("New Message published");