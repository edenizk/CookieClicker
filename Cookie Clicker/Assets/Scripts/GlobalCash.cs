using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour {

    public static int CashCount;

    public GameObject CashDisplay;

    public int InternalCash;

	// Update is called once per frame
	void Update ()
    {
        InternalCash = CashCount;

        CashDisplay.GetComponent<Text>().text = "Cash: $" + InternalCash;	
	}
}
