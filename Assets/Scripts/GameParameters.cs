using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class GameParameters : ScriptableObject
{
    public bool enableDayNightCycle;// to enable the day night cycle
    public float LengthOfDayInSeconds;//make it into minutes
    public float DayInitialRatio;//sets the day
}
