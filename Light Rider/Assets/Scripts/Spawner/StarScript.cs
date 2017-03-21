using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour {

	public StarSpawner spawner;
	private GameObject endPoint;
	private ValueHolder valueHolder;
	private Vector3 target;
	public float speed;
	// Use this for initialization
	void Start () {
		valueHolder = GameObject.FindWithTag ("ValueHolder").GetComponent<ValueHolder> ();
		endPoint = GameObject.FindGameObjectWithTag ("EndPoint");
		spawner = GameObject.FindWithTag ("StarSpawner").GetComponent<StarSpawner> ();
		spawner.starList.Add (this.gameObject);
		target = endPoint.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		target.y = this.transform.position.y;
		target.x = this.transform.position.x;
		this.transform.position = Vector3.MoveTowards (this.transform.position, target, speed * Time.deltaTime);
		if (Vector3.Distance (this.transform.position, target) <= 0)
			Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Destroy (this.gameObject);
			valueHolder.Score++;
		}
	}
}
