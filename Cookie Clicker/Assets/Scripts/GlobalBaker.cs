using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour {

    public GameObject fakeBakerButton;
    public GameObject fakeBakerText;
    public GameObject bakerButton;
    public GameObject bakerText;
    public GameObject bakerStatus;

    public int currentCash;

    public static int BakerNumber = 0;
    public static int BakerPerSec = 0;
    public static int BakerValue = 10;

    public static bool turnOffButton = false;
    
	void Update ()
    {
        currentCash = GlobalCash.CashCount;

        bakerStatus.GetComponent<Text>().text = "Baker(s): " + BakerNumber + "\n" + BakerPerSec + " Per Second"; 

        string bakerValueText = "Hire Baker   $" + BakerValue;

        fakeBakerText.GetComponent<Text>().text = bakerValueText;
        bakerText.GetComponent<Text>().text = bakerValueText;

        if (currentCash >= BakerValue)
        {
            fakeBakerButton.SetActive(false);
            bakerButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            bakerButton.SetActive(false);
            fakeBakerButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
