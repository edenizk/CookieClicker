using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour {

    public GameObject SaveButton;
    public GameObject StatusBox;

    public int SaveGameCash;
    public int SaveValue = 10;
    
	void Update ()
    {
        SaveGameCash = GlobalCash.CashCount;

        if(SaveGameCash >= SaveValue)
            SaveButton.GetComponent<Button>().interactable = true;

        else
            SaveButton.GetComponent<Button>().interactable = false;
    }

    public void SaveGameClicked()
    {
        GlobalCash.CashCount -= SaveValue;

        StatusBox.GetComponent<Text>().text = "$-10 Game Saved";
        StatusBox.GetComponent<Animation>().Play("StatusAnim");

        GlobalCashier.turnOffButton = true;
        GlobalBaker.turnOffButton = true;

        PlayerPrefs.SetInt("Cookies", GlobalCookies.CookieCount);
        PlayerPrefs.SetInt("Cash", GlobalCash.CashCount);

        PlayerPrefs.SetInt("BakerNumber", GlobalBaker.BakerNumber);
        PlayerPrefs.SetInt("BakerPerSec", GlobalBaker.BakerPerSec);
        PlayerPrefs.SetInt("BakerValue", GlobalBaker.BakerValue);

        PlayerPrefs.SetInt("CashierNumber", GlobalCashier.CashierNumber);
        PlayerPrefs.SetInt("CashierPerSec", GlobalCashier.CashierPerSec);
        PlayerPrefs.SetInt("CashierValue", GlobalCashier.CashierValue);
    }
}
