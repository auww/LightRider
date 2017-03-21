using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

	public bool ClickedOnce;
	public bool ClickedTwice;
	public float a;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			a = 0;
		}

		if (Input.GetMouseButtonUp (0)) {
			ClickedOnce = true;
		}

		if (ClickedOnce)
			a += Time.deltaTime;

		if (a >= .1f) {
			a = 0;
			ClickedOnce = false;
			ClickedTwice = false;
		}

		if (Input.GetMouseButtonDown (0) && ClickedOnce) {
			ClickedTwice = true;
			print ("yaho");
			a = 0;
			SendMessage ("playAnimation", "Jump", SendMessageOptions.RequireReceiver);
		}
	}
}
