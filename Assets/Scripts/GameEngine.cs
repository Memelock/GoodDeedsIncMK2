﻿using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
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
    public int Money, Deaths, GoodWill, Turn_Count, Starting_Money, Starting_Goodwill, Turn_Change;
    public int roulet_spins = 0;
    public Text  GWON;
    public TextMeshProUGUI Death_Text, GoodWill_Display, Money_Display, GW1, GW2, GW3, roulet, describtion, optiona, optionb, Turn_Display;
    Dessition Current;
    GoodWillOptions GoodWillCurent1, GoodWillCurent2, GoodWillCurent3;
    GoodWillOptions[] GWOS;
    public int MCDoogles_Total, WreckingCrew_Total, PoliticalCampaign_Total, Child_Slave_Mine_Total;
    public Slider com, com1, com2, com3;
    int past;
    public GameObject Good_Boi_Selected, Good_Boi_Selected2, Good_Boi_Selected3;
    // Start is called before the first frame update
    void Start()
    {
        New();
        GoodWillReroll();
        com.maxValue = 100;
        com1.maxValue = 100;
        com2.maxValue = 100;
        com3.maxValue = 100;
        Money = Starting_Money;
        GoodWill = Starting_Goodwill;
        MCDoogles_Total = 50;
        WreckingCrew_Total = 50;
        PoliticalCampaign_Total = 50;
        Child_Slave_Mine_Total = 50;
        Turn_Change = Turn_Count;
    }
    public int Rand_Des()
    {
        int r = Random.Range(0, dessitions.Count);

        return r;
    }
    public int Rand_GoodWill()
    {
        int r = Random.Range(0, GWO.Count);

        return r;
    }

    public void New()
    {
        Current = dessitions[Rand_Des()];
    }
    void GoodWillReroll()
    {
        GoodWillCurent1 = GWO[Rand_GoodWill()];
        GoodWillCurent2 = GWO[Rand_GoodWill()];
        while (GoodWillCurent1.Name == GoodWillCurent2.Name)
        {
            GoodWillCurent2 = GWO[Rand_GoodWill()];
        }
        GoodWillCurent3 = GWO[Rand_GoodWill()];
        while (GoodWillCurent3.Name == GoodWillCurent2.Name)
        {
            GoodWillCurent3 = GWO[Rand_GoodWill()];
        }
        Turn_Count++;  // Put to Vote, maybe free action
    }
    public void Passive_Income()
    {
        if (Turn_Count != Turn_Change)
        {

            if (Child_Slave_Mine_Total >= 50)
            {
                Money += (((Child_Slave_Mine_Total - 50) / 100) + 1) * 200;
            }
            if (Child_Slave_Mine_Total < 50)
            {
                Money += (((Child_Slave_Mine_Total - 50) / 100)) * 200;
            }
            if (MCDoogles_Total >= 50)
            {
                Money += (((MCDoogles_Total - 50) / 100) + 1) * 200;
            }
            if (MCDoogles_Total < 50)
            {
                Money += (((MCDoogles_Total - 50) / 100)) * 200;
            }
            if (WreckingCrew_Total >= 50)
            {
                Money += (((WreckingCrew_Total - 50) / 100) + 1) * 200;
            }
            if (WreckingCrew_Total < 50)
            {
                Money += (((WreckingCrew_Total - 50) / 100)) * 200;
            }
            if (PoliticalCampaign_Total >= 50)
            {
                Money += (((PoliticalCampaign_Total - 50) / 100) + 1) * 200;
            }
            if (PoliticalCampaign_Total < 50)
            {
                Money += (((PoliticalCampaign_Total - 50) / 100)) * 200;
            }
            Turn_Change = Turn_Count;
        }
    }
    public void Select(int selector)
    {
        if (selector == 1)
        {
            Money += Current.A.Moneyadded;
            GoodWill += Current.A.Good_Will;
            Deaths += Current.A.DeathsCaused;
            MCDoogles_Total += Current.A.MCdoogles;
            WreckingCrew_Total += Current.A.Wrecking_Crew;
            PoliticalCampaign_Total += Current.A.Political_Campaign;
            Child_Slave_Mine_Total += Current.A.Child_Slave_Mine;
        }
        if (selector == 2)
        {
            GoodWill += Current.B.Good_Will;
            Money += Current.B.Moneyadded;
            Deaths += Current.B.DeathsCaused;
            MCDoogles_Total += Current.B.MCdoogles;
            WreckingCrew_Total += Current.B.Wrecking_Crew;
            PoliticalCampaign_Total += Current.B.Political_Campaign;
            Child_Slave_Mine_Total += Current.B.Child_Slave_Mine;
        }
        Turn_Count++;
        New();
    }
    public void Disable_Button1()
    {
        if (Money >= GoodWillCurent1.Cost)
        {
            Money -= GoodWillCurent1.Cost;
            GoodWill += GoodWillCurent1.GWM;
            Good_Boi_Selected.SetActive(false);
            Turn_Count++;
        }
    }
    public void Disable_Button2()
    {
        if (Money >= GoodWillCurent2.Cost)
        {
            Money -= GoodWillCurent2.Cost;
            GoodWill += GoodWillCurent2.GWM;
            Good_Boi_Selected2.SetActive(false);
            Turn_Count++;
        }
    }
    public void Disable_Button3()
    {
        if (Money >= GoodWillCurent3.Cost)
        {
            Money -= GoodWillCurent3.Cost;
            GoodWill += GoodWillCurent3.GWM;
            Good_Boi_Selected3.SetActive(false);
            Turn_Count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Passive_Income();
        com.value = MCDoogles_Total;
        com1.value = WreckingCrew_Total;
        com2.value = PoliticalCampaign_Total;
        com3.value = Child_Slave_Mine_Total;
        describtion.text = Current.Description;
        GW1.text = GoodWillCurent1.Name + " $ " + GoodWillCurent1.Cost;
        GW2.text = GoodWillCurent2.Name + " $ " + GoodWillCurent2.Cost;
        GW3.text = GoodWillCurent3.Name + " $ " + GoodWillCurent3.Cost;
        optiona.text = Current.A.Name +" $ " + Current.A.Moneyadded;
        optionb.text = Current.B.Name + " $ " + Current.B.Moneyadded;
        roulet.text = "PR Research $" + Roulet_Cost();
        Money_Display.text = Money.ToString();
        Death_Text.text = Deaths.ToString();
        Turn_Display.text = Turn_Count.ToString();
        //if(GoodWill > 100)
        //{
        //    GoodWill = 100;
        //}
        //GoodWill_Display.text = GoodWill.ToString();
        //if(Turn_Count == 25)
        //{
        //    if(GoodWill <= 20 && Money <= 500)
        //    {

        //    }
        //    if(GoodWill > 20)
        //    {

        //    }
        //    if(Money > 500)
        //    {

        //    }
        //}

    }
    public void Roulet_detecter()
    {
        if (Money >= Roulet_Cost())
        {
            Money -= Roulet_Cost();
            GoodWillReroll();
            Good_Boi_Selected.SetActive(true);
            Good_Boi_Selected2.SetActive(true);
            Good_Boi_Selected3.SetActive(true);

            roulet_spins++;
        }
    }
    private int Roulet_Cost()
    {
        int cost = roulet_spins * 500 + 500;
        return cost;
    }

    private void OnMouseEnter()
    {
        print("test");
    }
}
//losing = $0 0 goodwill, or 20% goodwill/$500, each with different lose screen, 
//Winning = turn: 25 for demo
//Goodwill on scale from 1-100
//Starting $500 to start, will be balanced later
//starting goodwill = 75%