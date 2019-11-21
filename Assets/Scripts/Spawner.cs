using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int Count;
    public GameObject[] Spawnables;
    public float Buffer= 2f;
    public float OB;
    // Start is called before the first frame update
    void Start()
    {
        OB = Buffer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Buffer <= 0)
        {
                Count++;

            Instantiate(Spawnables[rand()], new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -1), Quaternion.identity);
            Buffer = OB-.1f;
        }
        else {
            Buffer -= .1f;
        }
    }
    int rand()
    {

        int r = Random.Range(0, Spawnables.Length);
        return r;
    }
}

