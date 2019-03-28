using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {

    public GameObject textBox;
    public AudioSource CookieSound;

    public void ClickButton()
    {
        GlobalCookies.CookieCount++;
        CookieSound.Play();
    }
}
