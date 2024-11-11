using Microsoft.Extensions.Logging;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

public struct EventData
{
    public int EventId { get; }
    public string EventType { get; }
    public DateTime EventTimestamp { get; }
    public int Floor { get; }

    public EventData(int eventId, string eventt, DateTime timeStamp, int floor)
    {
        EventId = eventId;
        EventType = eventt;
        EventTimestamp = timeStamp;
        Floor = floor;
    }
}


namespace LiftSimGame.Database
{
    public class LiftSimDatabase
    {

        private string connectionString = @"Server=ADITYA\MSSQLSERVER01;Database=Lift;Trusted_Connection=True;";

        public List<EventData> ReadEvents()
        {
            List<EventData> events = new List<EventData>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT EventId, EventType, EventTimestamp, Floor FROM LiftEvents;";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var eventData = new EventData(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetInt32(3)
                        );
                        events.Add(eventData);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return events;
        }

        public EventData InsertEvent(string eventType, int floor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                                    INSERT INTO LiftEvents (EventType, Floor) 
                                    OUTPUT INSERTED.EventId, INSERTED.EventType, INSERTED.EventTimestamp, INSERTED.Floor 
                                    VALUES (@EventType, @Floor)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventType", eventType);
                    command.Parameters.AddWithValue("@Floor", floor);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new EventData(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDateTime(2),
                                reader.GetInt32(3)
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting event: {ex.Message}");
                }
                return new EventData();
            }
        }

    }
}