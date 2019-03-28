using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour {

    public GameObject StatusBox;
    public float CookieCheck;
    public int GenChance;
    public bool DisasterActive = false;
    public int CookieLoss;

	void Update ()
    {
        CookieCheck = GlobalCookies.CookieCount / 10;
        if(DisasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
	}

    IEnumerator StartDisaster()
    {
        DisasterActive = true;
        GenChance = Random.Range(1, 20);

        if (CookieCheck >= GenChance)
        {
            CookieLoss = Mathf.RoundToInt(GlobalCookies.CookieCount * 0.25f);
            StatusBox.GetComponent<Text>().text = "You have lost " + CookieLoss + " cookies in factory fire";
            GlobalCookies.CookieCount -= CookieLoss;
            yield return new WaitForSeconds(3);
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(2);
            StatusBox.SetActive(false);
            StatusBox.SetActive(true);
        }

        yield return new WaitForSeconds(10);
        DisasterActive = false;
    }
}
