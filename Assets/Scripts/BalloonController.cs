using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public int clicksToPop = 20;

    void OnMouseDown()
    {
        clicksToPop -= 1;
        transform.localScale += new Vector3(0.15f, 0.15f, 0.15f);

        if(clicksToPop == 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
