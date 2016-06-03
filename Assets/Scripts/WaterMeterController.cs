using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
public class WaterMeterController : MonoBehaviour {

    public double startingWaterValue;
    public int NPC_Total;
    public double startingWaterDecreaseRate;
    public double totalTime;
    
    public int NPC_Interacted;
    public double currentWater;
    public double currentDecreaseRate;


    
    // Use this for initialization
    void Start () {
        currentWater = startingWaterValue;
        NPC_Interacted = 0;
        currentDecreaseRate = startingWaterDecreaseRate;
    }
	
	// Update is called once per frame
	void Update (){
        currentWater -= currentDecreaseRate * Time.deltaTime;
        totalTime += Time.deltaTime;
        GameOverCheck();
        WinCheck();
	}

    void GameOverCheck()
    {
        if (currentWater <= 0)
        {
            Application.LoadLevel("GameOverLose");
        }
    }


    void WinCheck()
    {
        if (NPC_Interacted >= NPC_Total)
        {
            Application.LoadLevel("GameOverWin");
        }
    }

    
}
