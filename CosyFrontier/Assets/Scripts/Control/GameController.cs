using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    EventController eventController;
    public TextAsset eventDataAsset;
    private void Awake()
    {
        eventController = new EventController(eventDataAsset);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
