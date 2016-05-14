using UnityEngine;
using System.Collections;

public class MagnetPowerUp : MonoBehaviour
{
    public GameObject flag;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            flag.gameObject.transform.Translate(new Vector3(0, 0, -20));
        }
    }
}
