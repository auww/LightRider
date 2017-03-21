using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	private Animator playerAnimator;

	// Use this for initialization
	void Start () {
		playerAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void playAnimation(string animation){
		playerAnimator.Play (animation);
	}
}
