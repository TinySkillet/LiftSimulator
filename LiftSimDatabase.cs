using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Drawing;

public struct EventData
{
    public int EventId { get; }
    public string EventType { get; }
    public DateTime EventTimestamp { get; }
    public int Floor { get; }

    public EventData(int eventId, string eventType, DateTime eventTimestamp, int floor)
    {
        EventId = eventId;
        EventType = eventType;
        EventTimestamp = eventTimestamp;
        Floor = floor;
    }
}

namespace LiftSimulator
{
    public class LiftSimDatabase
    {
        private readonly string connectionString;

        public LiftSimDatabase(string connString = null)
        {
            connectionString = connString ?? @"Server=ADITYA\MSSQLSERVER01;Database=Lift;Trusted_Connection=True;";
        }


        public List<EventData> ReadEvents()
        {

            List<EventData> events = new List<EventData>();
            DataTable eventTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT EventId, EventType, EventTimestamp, Floor FROM LiftEvents;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(eventTable);

                    foreach (DataRow row in eventTable.Rows)
                    {
                        var eventData = new EventData(
                            (int)row["EventId"],
                            (string)row["EventType"],
                            (DateTime)row["EventTimestamp"],
                            (int)row["Floor"]
                        );
                        events.Add(eventData);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading events: {ex.Message}");
                }
            }
            return events;
        }

        public EventData InsertEvent(string eventType, int floor)
        {
            DataTable eventTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT EventId, EventType, EventTimestamp, Floor FROM LiftEvents;";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Fill(eventTable);

                    DataRow newRow = eventTable.NewRow();
                    newRow["EventType"] = eventType;
                    newRow["EventTimestamp"] = DateTime.Now;
                    newRow["Floor"] = floor;
                    eventTable.Rows.Add(newRow);

                    adapter.Update(eventTable);

                    return new EventData(
                        (int)newRow["EventId"],
                        (string)newRow["EventType"],
                        (DateTime)newRow["EventTimestamp"],
                        (int)newRow["Floor"]
                    );
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
