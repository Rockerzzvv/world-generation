using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameParameters gameParameters;

    private void Awake()
    {
        GetComponent<DayNightCycler>().enabled = gameParameters.enableDayNightCycle;
        Application.targetFrameRate = 200;
    }
}
