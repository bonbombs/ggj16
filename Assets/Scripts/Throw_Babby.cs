using UnityEngine;
using System.Collections;

public class Throw_Babby : MonoBehaviour {

	public GameObject babby;

	// Use this for initialization
	void Start () {
		//Begin the animation.
		//Wait for animation to finish, and then a couple seconds

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space"))
			SpawnBabby ();
	}

	void SpawnBabby(){
		Instantiate(babby, new Vector3 ((16f * Random.value - 8f), 5f, 0f), babby.transform.rotation);
	}
}
