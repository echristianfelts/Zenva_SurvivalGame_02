using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 0;
        string playerName = "Ted";
        float jumpForce = 5.82f;
        bool gameOver = false;

        Debug.Log(transform.position);

        Vector3 testVector = new Vector3(10, 10, 10);

        transform.position += testVector;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
