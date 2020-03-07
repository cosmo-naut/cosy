using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController
{
    List<Event> eventPool;

    public EventController(TextAsset eventDataAsset)
    {
        eventPool = new List<Event>();
        ReadEvents(GetEventsFromAsset(eventDataAsset));
    }

    void ReadEvents(Event[] eventDatas)
    {
        foreach (Event eventData in eventDatas)
        {
            eventPool.Add(eventData);
        }
    }

    Event[] GetEventsFromAsset(TextAsset eventDataAsset)
    {
        string eventString = eventDataAsset.text;
        return Newtonsoft.Json.JsonConvert.DeserializeObject<Event[]>(eventString);
    }
}
