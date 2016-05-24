using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    private Animator anim;
    private Rigidbody rb;

    public float v;
    public float h;
    public float speed;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(h, 0.0f, v);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetFloat("vSpeed", v + 1);
            rb.AddForce(movement * speed);
            
        }
        else
            anim.SetFloat("vSpeed", v);
        anim.SetFloat("hSpeed", h);
        anim.SetFloat("direction", h);

        if (Input.GetKeyDown("1"))
        {
            if(anim.GetInteger("CurrentAction") == 0)
            {
                anim.SetInteger("CurrentAction", 1);
            } else if (anim.GetInteger("CurrentAction") == 1)
            {
                anim.SetInteger("CurrentAction", 0);
            }
        }
	}
}
