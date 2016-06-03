using UnityEngine;
using System.Collections;

public class ResultsScript : MonoBehaviour {
    public WaterMeterController WaterMeterScript;
    private double totalTime;
    private double currentWater;
    public string time;
    public string score;

    // Use this for initialization
    void Start () {
        totalTime = WaterMeterScript.totalTime;
        currentWater = WaterMeterScript.currentWater;
        time = "Total Time: " + totalTime.ToString() + " seconds.";
        score = "Gallons of water saved: " + score.ToString();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
