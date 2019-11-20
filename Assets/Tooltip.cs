using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameEngine GE;
    public TextMeshProUGUI TTT;
    public bool B, onhover;
    [SerializeField]
    public GameObject toolTip;
    Vector3 offset = new Vector3(0,35,0);
    public Sprite[] icons;
    public Image Icontoshow, I2, I3, I4, I5;
    // Shows tool tip when hovering over a choice box.
    public void OnPointerEnter(PointerEventData eventData)
    {
        onhover = true;
        Calculate();
        ShowToolTip(transform.position);
    }
    void Calculate() {

        if (B == false)
        {
            if (GE.Current.A.MCdoogles != 0)
            {
                Icontoshow.sprite = icons[0];
            }
            else { Icontoshow.sprite = null; }
            if (GE.Current.A.Political_Campaign != 0)
            {
                I2.sprite = icons[1];
            }
            else { I2.sprite = null; }
            if (GE.Current.A.Wrecking_Crew != 0)
            {
                I3.sprite = icons[2];
            }
            else { I3.sprite = null; }
            if (GE.Current.A.Building != 0)
            {
                I4.sprite = icons[3];
            }
            else { I4.sprite = null; }
            if (GE.Current.A.Child_Slave_Mine != 0)
            {
                I5.sprite = icons[4];
            }
            else { I5.sprite = null; }
            TTT.text = "Money: $" + GE.Current.A.Moneyadded.ToString(); //+ " Deaths" + GE.Current.A.Moneyadded.ToString();
        }
        else
        {
            if (GE.Current.B.MCdoogles != 0)
            {
                Icontoshow.sprite = icons[0];
            }
            else { Icontoshow.sprite = null; }
            if (GE.Current.B.Political_Campaign != 0)
            {
                I2.sprite = icons[1];
            }
            else { I2.sprite = null; }
            if (GE.Current.B.Wrecking_Crew != 0)
            {
                I3.sprite = icons[2];
            }
            else { I3.sprite = null; }
            if (GE.Current.B.Building != 0)
            {
                I4.sprite = icons[3];
            }
            else { I4.sprite = null; }
            if (GE.Current.B.Child_Slave_Mine != 0)
            {
                I5.sprite = icons[4];
            }
            TTT.text = " Money: $" + GE.Current.B.Moneyadded.ToString();// + "Deaths" + GE.Current.B.Moneyadded.ToString();
        }
    }

    // Hides tool tip when not hovering over text box.
    public void OnPointerExit(PointerEventData eventData)
    {
        onhover = false;
        toolTip.SetActive(false);
    }

    // Retrieves location of choice box and activates tool tip.
    public void ShowToolTip(Vector3 position)
    {
        toolTip.SetActive(true);
        toolTip.transform.position = position+offset;

    }

    private void Update()
    {
        if (onhover)
        {
            Calculate();
        }
    }

public interface IDescribable
{
    string GetDescription();
}
}
    
