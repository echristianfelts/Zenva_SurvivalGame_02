using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZNV_BowlingBall : MonoBehaviour
{

    public float forwardForce;
    public float leftBoarder;
    public float rightBoarder;
    public float moveIncrement;
    public Rigidbody rig;

    public void Bowl()
    {
        rig.AddForce(transform.forward * forwardForce,ForceMode.Impulse);

    }

    // Start is called before the first frame update
    void Start()
    {
        //  Bowl();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Bowl();

        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();

        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();

        }
    }

    public void MoveLeft()
    {
        if (transform.position.x > leftBoarder)
        {
            transform.position += new Vector3(-moveIncrement, 0, 0);
        }
    }

    public void MoveRight()
    {
        if (transform.position.x < rightBoarder)
        {
            transform.position += new Vector3(moveIncrement, 0, 0);
        }
    }



}
