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
public class Option {
    public string Name;
    public int DeathsCaused, Moneyadded;
    public int company, company1, company2, company3;
}
public class GameEngine : MonoBehaviour
{
    [SerializeField] List<Dessition> dessitions = new List<Dessition>();
    public int Money, Deaths;
    public Text describtion, optiona, optionb, MT,Dealths;
    public Dessition Current;
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
       int r= Random.Range(0, dessitions.Count);

        return r;
    }
    public void New() {
        Current = dessitions[Rand()] ;
    }

    public void Select(int selector)
    {
        if (selector==1) {
            Money += Current.A.Moneyadded;
            Deaths += Current.A.DeathsCaused;
            C += Current.A.company;
            C1 += Current.A.company1;
            C2 += Current.A.company2;
            C3 += Current.A.company3;
        }
        if (selector ==2)
        {
            Money += Current.B.Moneyadded;
            Deaths += Current.B.DeathsCaused;
            C += Current.B.company;
            C1 += Current.B.company1;
            C2 += Current.B.company2;
            C3 += Current.B.company3;
        }
        New();
    }
    // Update is called once per frame
    void Update()
    {
        com.value = C;
        com1.value = C1;
        com2.value = C2;
        com3.value = C3;
        describtion.text = Current.Description;
        optiona.text = Current.A.Name;
        optionb.text = Current.B.Name;
        MT.text = Money.ToString();
        Dealths.text = Deaths.ToString();

    }
}
