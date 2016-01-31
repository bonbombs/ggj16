using UnityEngine;
using System.Collections;

public class CrowdController : MonoBehaviour {

    public float multiplier = 0.8f;
    
    private Animator crowd_anim;
    

    // Use this for initialization
    void Start () {
        crowd_anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Check # of babies caught vs anger meter
        //The more babies, the faster the crowd bobs about
        //For now, just do this
        crowd_anim.speed = Random.Range(0.1f, multiplier);
    }
}
