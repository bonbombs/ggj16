using UnityEngine;
using System.Collections;

public class Babby : MonoBehaviour {

    private int bouncy;
    public float babby_speed;
    public int babby_score;
    public int babby_crowd;
    //Potato

	// Use this for initialization
	void Start () {
        bouncy = 0;
        GetComponent<Rigidbody2D>().drag = babby_speed;
	}
	
	public void set_bouncy(int newbouncy)
    {
        bouncy = newbouncy;
    }

    public int get_bouncy()
    {
        return bouncy;
    }
}
