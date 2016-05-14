using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {
    public GameObject popup;
	// Use this for initialization
	void Start () {
        popup.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        popup.SetActive(true);
	}

    void OnTriggerExit(Collider other)
    {
        popup.SetActive(false);
    }
}
