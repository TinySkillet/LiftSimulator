using LiftSimulator;

public class EventLogger
{
    private readonly LiftSimDatabase db;

    public EventLogger()
    {
        db = new LiftSimDatabase();
    }

    public void LogEvent(string eventType, int floor, DataGridView logsTable)
    {
        try
        {
            EventData newEvent = db.InsertEvent(eventType, floor);

            AddLogToTable(newEvent, logsTable);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error logging event: {ex.Message}");
        }
    }

    private void AddLogToTable(EventData eventData, DataGridView logsTable)
    {
        if (logsTable.InvokeRequired)
        {
            logsTable.Invoke(new Action(() => AddLogToTable(eventData, logsTable)));
            return;
        }

        logsTable.Rows.Add(
            eventData.EventId,
            eventData.EventType,
            eventData.EventTimestamp,
            eventData.Floor
        );

    }
}