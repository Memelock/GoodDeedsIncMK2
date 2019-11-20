using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Appcontroller : MonoBehaviour
{
    public GameObject Main, Profit, PR, info, help, initial, exit, El_Banco, Poverty, Badwill, willandPov, ChickenDinner, COWARD;
    // Start is called before the first frame update
    void Start()
    {
        Main.SetActive(false);
        Profit.SetActive(false);
        PR.SetActive(false);
        info.SetActive(false);
        help.SetActive(false);
        initial.SetActive(true);
        El_Banco.SetActive(false);
        Poverty.SetActive(false);
        Badwill.SetActive(false);
        willandPov.SetActive(false);
        ChickenDinner.SetActive(false);
        COWARD.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Open(8);
        }
    }

    public void Open(int selector) {
        if (selector==1) {
            Main.SetActive(true);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);

        }
        if (selector == 2)
        {
            Main.SetActive(false);
            Profit.SetActive(true);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            El_Banco.SetActive(false);

            initial.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);

        }
        if (selector == 3)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(true);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);

        }
        if (selector == 4)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(true);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);
        }
        if (selector == 5)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(true);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);
        }
        if (selector == 6)
        {
            Main.SetActive(true);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);
        }
        if (selector == 7)
        {
            Application.Quit();
            print("quit");

        }
        if (selector == 8)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(true);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);
        }
        if (selector == 9)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(true);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);
        }
        if(selector == 10)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(true);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);
        }
        if (selector == 11)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(true);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);
        }
        if (selector == 12)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(true);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(false);
        }
        if (selector == 13)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(true);
            COWARD.SetActive(false);
        }
        if (selector == 14)
        {
            Main.SetActive(false);
            Profit.SetActive(false);
            PR.SetActive(false);
            info.SetActive(false);
            help.SetActive(false);
            initial.SetActive(false);
            El_Banco.SetActive(false);
            Poverty.SetActive(false);
            Badwill.SetActive(false);
            willandPov.SetActive(false);
            ChickenDinner.SetActive(false);
            COWARD.SetActive(true);
        }
    }
}
