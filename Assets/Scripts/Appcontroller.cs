using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appcontroller : MonoBehaviour
{
    public GameObject Main, Profit, PR, info, help;
    // Start is called before the first frame update
    void Start()
    {
        Main.SetActive(true);
        Profit.SetActive(false);
        PR.SetActive(false);
        info.SetActive(false);
        help.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open(int selector) {
        if (selector==1) {
            Main.SetActive(true);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
        }
        if (selector == 2)
        {
            Main.SetActive(false);
            Profit.SetActive(true);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
        }
        if (selector == 3)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(true);
            info.SetActive(false);
            help.SetActive(false);
        }
        if (selector == 4)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(true);
            help.SetActive(false);
        }
        if (selector == 5)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(true);
        }
    }
}
