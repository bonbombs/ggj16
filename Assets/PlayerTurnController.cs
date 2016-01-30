using UnityEngine;
using System.Collections;

public class PlayerTurnController : MonoBehaviour {

    public GameObject player1, player2;
    private PlayerController p1c, p2c;
    private SpriteRenderer p1sr, p2sr;

	// Use this for initialization
	void Start () {
        p1c = player1.GetComponent<PlayerController>();
        p2c = player2.GetComponent<PlayerController>();
        p1sr = player1.GetComponent<SpriteRenderer>();
        p2sr = player2.GetComponent<SpriteRenderer>();    
	}
	
	// Update is called once per frame
	void Update () {
	    if(player1.transform.position.x > player2.transform.position.x)
        {
        }
	}
}
