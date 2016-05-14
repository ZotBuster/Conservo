using UnityEngine;
using System.Collections;

public class KeyRotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(30, 45, 30) * Time.deltaTime);

    }
}
