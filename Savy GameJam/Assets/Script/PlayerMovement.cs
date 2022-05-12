using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    private Touch tch;

    [SerializeField] float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            tch = Input.GetTouch(0);

            if (tch.phase == TouchPhase.Began)
            {
                print("jump by touch");
                rb.AddForce(transform.up *  jumpPower);

            }

        } else if (Input.GetKeyDown("space"))
        {
            print("jump using space button");
            rb.AddForce(transform.up * jumpPower);


        }
    } 

}
