using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeed : MonoBehaviour
{
    public float initialTimeScale = 1.0f; //staritng speed of the game
    public float maxTimeScale = 5.0f;    //maximum speed the game can reach
    public float speedIncreaserate = 0.5f;  //how quickly the speed increases over time
    public float timeToMaxSpeed = 60f;  //time in seconds to reach max speed;

    private float elapsedTime = 0f;

    void Start()
    {
        //set the initial time scale when the game starts
        Time.timeScale = initialTimeScale;
    }

    void Update()
    {
        //increment elapsed time by the time passed since the last frame
        elapsedTime += Time.deltaTime;

        //Calculate the new time scale based on the elapsed time
        float newTimeScale = Mathf.Lerp(initialTimeScale, maxTimeScale, elapsedTime / timeToMaxSpeed);

        //Apply the new time scale
        Time.timeScale = newTimeScale;

//optionally clamp the time scale to the max value to avoid exceeding it
Time.timeScale = Mathf.Clamp(Time.timeScale, initialTimeScale, maxTimeScale);
    }

    //Resetting the time scale when the game ends or reset
    void OnDestroy()
    {
        Time.timeScale = 1.0f;
    }

}
