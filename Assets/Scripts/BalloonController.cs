using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public int scoretoGive = 1;
    public int clicksToPop = 20;
    public float scaleIncreasePerClick = 0.1f;
    public ScoreManager scoreManager;

    void OnMouseDown()
    {
        clicksToPop -= 1;
        //  transform.localScale += new Vector3(0.15f, 0.15f, 0.15f);
        transform.localScale += Vector3.one * scaleIncreasePerClick;
        if (clicksToPop == 0)
        {
            scoreManager.IncreaseScore(scoretoGive);
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
