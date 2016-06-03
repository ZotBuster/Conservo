using UnityEngine;
using System.Collections;

public class MeterDecreaseScript : MonoBehaviour {

    public Vector2 pos = new Vector2(20, 40);
    public Vector2 size = new Vector2(20, 60);
    public Texture2D emptyTex;
    public Texture2D fullTex;
    public double currentwater; //new progress
    public double startingwater;

    public WaterMeterController WaterMeterScript;

    // Use this for initialization
    void Start()
    {
        startingwater = WaterMeterScript.startingWaterValue;
        currentwater = WaterMeterScript.startingWaterValue;
    }

    void OnGUI()
    {
        //draw the background:
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), emptyTex);

        //draw the filled-in part:
        GUI.BeginGroup(new Rect(0, 0, size.x, size.y * (float)currentwater));
        GUI.Box(new Rect(0, 0, size.x, size.y), fullTex);
        GUI.EndGroup();
        GUI.EndGroup();
    }

    // Update is called once per frame
    void Update () {
        //for this example, the bar display is linked to the current time,
        //however you would set this value based on your desired display
        //eg, the loading progress, the player's health, or whatever.
        currentwater = (WaterMeterScript.currentWater / startingwater);
    }
}
