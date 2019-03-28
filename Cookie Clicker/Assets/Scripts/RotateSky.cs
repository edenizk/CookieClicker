using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour {

    public float rotateSpeed = 1.1f;

	void Update ()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
	}
}
