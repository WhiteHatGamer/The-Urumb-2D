using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float Speed=15.0f;
    private float temp;
    private float v;
    private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    /*void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.Translate( h * Time.deltaTime * Speed, v * Time.deltaTime * Speed, 0, Space.World);


    }*/
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) == true )
        {
            anim.enabled = true;
        }
        else
        {
            anim.enabled = false;
        }
        temp = h;
        transform.Translate(h * Time.deltaTime * Speed, 0, 0, Space.World);
    }

    // called when the cube hits the floor
    void OnCollisionStay2D(Collision2D col)
    {
        v = Input.GetAxis("Vertical");
        transform.Translate(0, v * Time.deltaTime * Speed, 0, Space.World);
        Debug.Log("OnCollisionStay2D");
    }
}
