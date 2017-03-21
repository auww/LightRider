using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour {

	private PlayerAnimation playerAnim;
	public string animationClip;
	public Vector3 direction;

	// Use this for initialization
	void Start () {
		playerAnim = GameObject.FindWithTag ("Player").GetComponent<PlayerAnimation> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		playerAnim.playAnimation (animationClip);
	}
}
