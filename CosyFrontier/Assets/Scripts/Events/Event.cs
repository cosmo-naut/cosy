using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Event
{
    public string id;
    public string title;
    public string description;
    public Option[] options;

    public void Select(int selectionIndex)
    {
        Debug.Log(string.Format("Invoking {0}-{1}", id, selectionIndex));
        options[selectionIndex].Invoke();
    }

    [Serializable]
    public class Option
    {
        public string description;

        public void Invoke()
        {
            
        }
    }
}


