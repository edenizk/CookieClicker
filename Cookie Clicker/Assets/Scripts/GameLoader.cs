using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

    public int LoadCookieCount;
    public int LoadCashCount;

    public int LoadBakerNumber;
    public int LoadBakerPerSec;
    public int LoadBakerValue;

    public int LoadCashierNumber;
    public int LoadCashierPerSec;
    public int LoadCashierValue;



    void Start () {

        if (MainMenuOptions.isLoading == true)
        {
            LoadCookieCount = PlayerPrefs.GetInt("Cookies");
            GlobalCookies.CookieCount = LoadCookieCount;

            LoadCashCount = PlayerPrefs.GetInt("Cash");
            GlobalCash.CashCount = LoadCashCount;

            LoadBakerNumber = PlayerPrefs.GetInt("BakerNumber");
            GlobalBaker.BakerNumber = LoadBakerNumber;

            LoadBakerPerSec = PlayerPrefs.GetInt("BakerPerSec");
            GlobalBaker.BakerPerSec = LoadBakerPerSec;

            LoadBakerValue = PlayerPrefs.GetInt("BakerValue");
            GlobalBaker.BakerValue = LoadBakerValue;

            LoadCashierNumber = PlayerPrefs.GetInt("CashierNumber");
            GlobalCashier.CashierNumber = LoadCashierNumber;

            LoadCashierPerSec = PlayerPrefs.GetInt("CashierPerSec");
            GlobalCashier.CashierPerSec = LoadCashierPerSec;

            LoadCashierValue = PlayerPrefs.GetInt("CashierValue");
            GlobalCashier.CashierValue = LoadCashierValue;
        }

	}
}
