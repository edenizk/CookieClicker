using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookie : MonoBehaviour {

    public bool CreatingCookie = false;

    public static int CookieInc;

    public int InternalInc;

	
	void Update ()
    {
        CookieInc = GlobalBaker.BakerPerSec;

        InternalInc = CookieInc;

        if(CreatingCookie == false)
        {
            CreatingCookie = true;
            StartCoroutine(CreateCookie());
        }
	}

    IEnumerator CreateCookie()
    {
        GlobalCookies.CookieCount += CookieInc;
        yield return new WaitForSeconds(0.75f);
        CreatingCookie = false;
    }
}
