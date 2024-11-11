public interface IEventAdapter
{
    List<EventData> ReadEvents();
    EventData InsertEvent(string eventType, int floor);
}
