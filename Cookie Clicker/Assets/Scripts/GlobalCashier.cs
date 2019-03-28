using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCashier : MonoBehaviour {

    public GameObject fakeCashierButton;
    public GameObject fakeCashierText;
    public GameObject CashierButton;
    public GameObject CashierText;
    public GameObject CashierStatus;

    public int currentCash;

    public static int CashierNumber = 0;
    public static int CashierPerSec = 0;
    public static int CashierValue = 10;

    public static bool turnOffButton = false;
    
	void Update ()
    {
        currentCash = GlobalCash.CashCount;

        CashierStatus.GetComponent<Text>().text = "Cashier(s): " + CashierNumber + "\n" + CashierPerSec + " Per Second"; 

        string CashierValueText = "Hire Cashier   $" + CashierValue;

        fakeCashierText.GetComponent<Text>().text = CashierValueText;
        CashierText.GetComponent<Text>().text = CashierValueText;

        if (currentCash >= CashierValue)
        {
            fakeCashierButton.SetActive(false);
            CashierButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            CashierButton.SetActive(false);
            fakeCashierButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
