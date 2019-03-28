using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour {

    public bool SellingCookie = false;

    public static int SellInc;

    public int InternalInc;

	
	void Update ()
    {
        SellInc = GlobalCashier.CashierPerSec;

        InternalInc = SellInc;

        if(SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellCookie());
        }
	}

    IEnumerator SellCookie()
    {

        if(GlobalCookies.CookieCount > 0)
        {
            if(SellInc > GlobalCookies.CookieCount)
            {
                GlobalCash.CashCount += GlobalCookies.CookieCount;
                GlobalCookies.CookieCount = 0;
            }
            else
            {
                GlobalCookies.CookieCount -= SellInc;
                GlobalCash.CashCount += SellInc;
            }
        }

        yield return new WaitForSeconds(1);
        SellingCookie = false;
    }
}
