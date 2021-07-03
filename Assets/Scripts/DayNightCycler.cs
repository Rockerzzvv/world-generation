using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycler : MonoBehaviour
{
    public GameParameters gameParameters;
    public Transform starTransform;

    public float starRefreshRate_Seconds;
    private float rotationAngleStep;
    private Vector3 rotationAxis;

    private void Awake()
    {
        starTransform.rotation = Quaternion.Euler(gameParameters.DayInitialRatio * 360f, -30f , 0);

        starRefreshRate_Seconds = 0.1f;
        rotationAxis = starTransform.right;
        rotationAngleStep = (360f * starRefreshRate_Seconds) /gameParameters.LengthOfDayInSeconds;
    }

    private void Start()
    {
        StartCoroutine("UpdateStarRotation");
    }
    private IEnumerator UpdateStarRotation()
    {
        while (true)
        {
            starTransform.Rotate(rotationAxis, rotationAngleStep, Space.World);
            yield return new WaitForSeconds(starRefreshRate_Seconds);
        }
    }
}
