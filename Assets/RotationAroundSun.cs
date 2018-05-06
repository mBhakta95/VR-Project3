using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundSun : MonoBehaviour {

    public float rotateSpeed = 0.000f;
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.up,  Time.deltaTime + rotateSpeed);
    }
}
