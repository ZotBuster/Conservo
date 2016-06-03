using UnityEngine;
using System.Collections;

public class WinMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int scenenumber = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
            Application.LoadLevel("Results");

    }
}
