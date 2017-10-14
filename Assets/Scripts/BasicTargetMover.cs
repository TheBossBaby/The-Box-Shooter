using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {
	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;
	public bool doSpin = true;
	public bool doMotion = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(doSpin){
			//Rotate object around up(Y) axis
			gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
		}
		if (doMotion) {
			//Move object up and down
			gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude );
		}	

	}
}
