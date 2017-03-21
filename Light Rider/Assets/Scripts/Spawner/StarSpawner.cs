using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour {

	public GameObject star;
	public List<GameObject> starList = new List<GameObject> ();
	public int starCount;
	private float currentTime;
	// Use this for initialization
	void Start () {
//		for (int i = 0; i < starCount; i++) {
//			Instantiate (star, transform.position, transform.rotation, this.transform);
//		}


	}
	
	// Update is called once per frame
	void Update () {
		int a = Random.Range (1, 4);
		currentTime += 1 * Time.deltaTime;
		if (currentTime >= .5) {
			currentTime = 0;
			if(a == 2)
				Instantiate (star, transform.position + new Vector3(5,0,0), transform.rotation, this.transform);
			else if(a == 1)
				Instantiate (star, transform.position + new Vector3(-5,0,0), transform.rotation, this.transform);
			else 
				Instantiate (star, transform.position, transform.rotation, this.transform);
				
		}
	}

//	IEnumerator spawn(){
//		yield return new WaitForSeconds (3);
//		Instantiate (star, transform.position, transform.rotation, this.transform);
//		yield return new WaitForSeconds (3);
//	}
}
