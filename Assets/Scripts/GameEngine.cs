using System.Collections;
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
    public int DeathsCaused, Moneyadded,GDA;
    public int company, company1, company2, company3;
}
public class GameEngine : MonoBehaviour
{
    [SerializeField] List<Dessition> dessitions = new List<Dessition>();
    [SerializeField] List<GoodWillOptions> GWO = new List<GoodWillOptions>();
    public int Money, Deaths, GoodWill;
    public Text describtion, optiona, optionb, MT, Dealths, GWON;
    public Dessition Current;
    public GoodWillOptions CurrentGWO;
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
    public int Rand() {
        int r = Random.Range(0, dessitions.Count);

        return r;
    }
    public void New() {
        Current = dessitions[Rand()];
    }
    void new2(){
        CurrentGWO = GWO[Rand()];
    }

    public void Select(int selector)
    {
        if (selector==1) {
            Money += Current.A.Moneyadded;
            GoodWill += Current.A.GDA;
            Deaths += Current.A.DeathsCaused;
            C += Current.A.company;
            C1 += Current.A.company1;
            C2 += Current.A.company2;
            C3 += Current.A.company3;
        }
        if (selector ==2)
        {
            GoodWill += Current.B.GDA;
            Money += Current.B.Moneyadded;
            Deaths += Current.B.DeathsCaused;
            C += Current.B.company;
            C1 += Current.B.company1;
            C2 += Current.B.company2;
            C3 += Current.B.company3;
        }
        New();
    }
    public void Select2()
    {
        if (Money >= CurrentGWO.Cost) {
            GoodWill += CurrentGWO.GWM;
            Money -= CurrentGWO.Cost;

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
        GWON.text = CurrentGWO.Name;
        describtion.text = Current.Description;
        optiona.text = Current.A.Name;
        optionb.text = Current.B.Name;
        MT.text = Money.ToString();
        Dealths.text = Deaths.ToString();

    }
}
