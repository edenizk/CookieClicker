using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour {

    //public GameObject textBox;

    public GameObject statusBox;

    public AudioSource cashOne;
    public AudioSource cashTwo;
    public AudioSource FailSound;

    public int generateTone;

    public void ClickButton()
    {
        generateTone = Random.Range(1, 3);

        if (GlobalCookies.CookieCount > 0)
        {
            if (generateTone == 1)
                cashOne.Play();
            else if (generateTone == 2)
                cashTwo.Play();

            GlobalCookies.CookieCount--;
            GlobalCash.CashCount++;
        }
        else if (GlobalCookies.CookieCount == 0)
        {
            FailSound.Play();
            statusBox.GetComponent<Text>().text = "Not enough cookies to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }
}
