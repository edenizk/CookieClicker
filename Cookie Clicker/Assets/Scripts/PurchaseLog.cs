using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour {

    public GameObject AutoCookie;
    public GameObject AutoSell;

    public GameObject StatusBox;

    public AudioSource playSound;

    public void StartAutoCookie()
    {
        playSound.Play();

        AutoCookie.SetActive(true);

        StatusBox.GetComponent<Text>().text = "$-" + GlobalBaker.BakerValue + " Baker Hired";
        StatusBox.GetComponent<Animation>().Play("StatusAnim");

        GlobalCash.CashCount -= GlobalBaker.BakerValue;
        GlobalBaker.BakerValue *= 2;
        GlobalCashier.turnOffButton = true;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.BakerPerSec++;
        GlobalBaker.BakerNumber++;
    }

    public void StartAutoSell()
    {
        playSound.Play();

        AutoSell.SetActive(true);

        StatusBox.GetComponent<Text>().text = "$-" + GlobalCashier.CashierValue + " Baker Hired";
        StatusBox.GetComponent<Animation>().Play("StatusAnim");

        GlobalCash.CashCount -= GlobalCashier.CashierValue;
        GlobalCashier.CashierValue *= 2;
        GlobalCashier.turnOffButton = true;
        GlobalBaker.turnOffButton = true;
        GlobalCashier.CashierPerSec++;
        GlobalCashier.CashierNumber++;
    }
}
