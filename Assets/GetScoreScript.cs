using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetScoreScript : MonoBehaviour {

    public float water = PlayerPrefs.GetFloat("Water");
    public float time = PlayerPrefs.GetFloat("Time");
    public Text scoretext;
    public Text watertext;

    // Use this for initialization
    void Start ()
    {

        scoretext.text = (water * time).ToString();
        watertext.text = water.ToString();
    }

    // Update is called once per frame
    void Update () {
	
	}
}   
