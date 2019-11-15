﻿using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dessition{
    public string Description;
    [SerializeField] public Option A,B;

}


[System.Serializable]
public class GoodWillOptions
{
    public string Name;
    public int GWM;
    public int Cost;
}

[System.Serializable]
public class Option {
    public string Name;
    public int DeathsCaused, Moneyadded,Good_Will; // Good_Will formerly GDA
    public int MCdoogles, Wrecking_Crew, Political_Campaign, Child_Slave_Mine;
}
public class GameEngine : MonoBehaviour
{
    [SerializeField] List<Dessition> dessitions = new List<Dessition>();
    [SerializeField] List<GoodWillOptions> GWO = new List<GoodWillOptions>();
    public int Money, Deaths, GoodWill;
    public UnityEngine.UI.Text describtion, optiona, optionb, MT, Dealths, GWON, GW1, GW2, GW3;
    Dessition Current;
    GoodWillOptions Current2;
    GoodWillOptions[] GWOS;
    public int C, C1, C2, C3;
    public Slider com, com1, com2, com3;
    int past;
    // Start is called before the first frame update
    void Start()
    {
        New();
        com.maxValue = 100;
        com1.maxValue = 100;
        com2.maxValue = 100;
        com3.maxValue = 100;
    }
    public int Rand()
    {
        int r = Random.Range(0, dessitions.Count);

        return r;
    }
    public void New()
    {
        Current = dessitions[Rand()];
    }
    void new2()
    {

        GWOS[0] = GWO[Rand()];
        GWOS[1] = GWO[Rand()];
        GWOS[2] = GWO[Rand()];
        GW1.text = GWOS[0].Name +" " + GWOS[0].Cost;
        GW2.text = GWOS[1].Name;
        GW3.text = GWOS[2].Name;
    }

    public void Select(int selector)
    {
        if (selector == 1)
        {
            Money += Current.A.Moneyadded;
            GoodWill += Current.A.Good_Will;
            Deaths += Current.A.DeathsCaused;
            C += Current.A.MCdoogles;
            C1 += Current.A.Wrecking_Crew;
            C2 += Current.A.Political_Campaign;
            C3 += Current.A.Child_Slave_Mine;
        }
        if (selector == 2)
        {
            GoodWill += Current.B.Good_Will;
            Money += Current.B.Moneyadded;
            Deaths += Current.B.DeathsCaused;
            C += Current.B.MCdoogles;
            C1 += Current.B.Wrecking_Crew;
            C2 += Current.B.Political_Campaign;
            C3 += Current.B.Child_Slave_Mine;
        }
        New();
    }
    public void Select2()
    {
        Current2 = GWO[Rand()];
        print(Current2.Name);
        if (Money >= Current2.Cost)
        {
            GoodWill += Current2.GWM;
            Money -= Current2.Cost;

            new2();
        }
    }
    // Update is called once per frame
    void Update()
    {
        com.value = C;
        com1.value = C1;
        com2.value = C2;
        com3.value = C3;
        describtion.text = Current.Description;
        optiona.text = Current.A.Name +" $ " + Current.A.Moneyadded;
        optionb.text = Current.B.Name;
        MT.text = Money.ToString();
        Dealths.text = Deaths.ToString();

    }

    private void OnMouseEnter()
    {
        print("test");
    }
}
