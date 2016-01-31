using UnityEngine;
using System.Collections;

public class Destroy_Babby : MonoBehaviour {

    public AudioClip boo;
    private AudioSource source;

    // Use this for initialization 
    void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Babby")
        {
            //Babby dropped
            ScoreKeeper sk = ScoreKeeper.Instance;
            source.PlayOneShot(boo, .75f);
            sk.currentCrowd = sk.currentCrowd - 1;
            Destroy(collision.gameObject);
        }
    }
}