using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	public Text score;
	public ValueHolder valueHolder;
	// Use this for initialization
	void Start () {
		valueHolder = GameObject.FindGameObjectWithTag ("ValueHolder").GetComponent<ValueHolder> ();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + valueHolder.Score.ToString();
	}
}
