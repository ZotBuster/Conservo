using UnityEngine;
using System.Collections;

public class WaterMeterController : MonoBehaviour {

    public float startingWaterValue;
    public int NPC_Total;
    public float startingWaterDecreaseRate;
    public float totalTime;
    
    private int NPC_Interacted;
    private float currentWater;
    private float currentDecreaseRate;
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
        if (NPC_Interacted <= 0)
        {
            Application.LoadLevel("GameOverWin");
        }
    }
}
