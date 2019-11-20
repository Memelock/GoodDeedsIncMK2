using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decor : MonoBehaviour
{
    public Sprite[] Pics;
    public float Time = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time > 0)
        {
            Time--;
        }
        else
        {
            Time = 2f;
            gameObject.GetComponent<SpriteRenderer>().sprite = Pics[rand()];
        }

    }
    int rand() {

        int r = Random.Range(0, Pics.Length);
        return r;
    }
}
