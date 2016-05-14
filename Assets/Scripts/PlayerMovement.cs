using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float walkspeed;
    public float rotatespeed;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;

    }

    void FixedUpdate()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * rotatespeed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * walkspeed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
    }
}