using LiftSimGame.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftSimGame.Managers
{
    internal class EventLogger : LiftSimDatabase
    {
        public void LogEvent(string eventType, int floor, DataGridView logsTable)
        {
            EventData insertedEvent = InsertEvent(eventType, floor);
            logsTable.Rows.Add(insertedEvent.EventId, insertedEvent.EventType, insertedEvent.EventTimestamp, insertedEvent.Floor);
            logsTable.Sort(logsTable.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        public void ClearLogs(DataGridView logsTable)
        {
            logsTable.Rows.Clear();
        }
    }
}
