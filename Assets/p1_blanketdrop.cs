using UnityEngine;
using System.Collections;

public class p1_blanketdrop : MonoBehaviour {

    public HingeJoint2D hinge;
    private PlayerController pc1;
	
    // Use this for initialization
	void Start ()
    {
        hinge = GetComponent<HingeJoint2D>();
        pc1 = GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            hinge.enabled = !hinge.enabled;
            pc1.isHoldingBlanket = hinge.enabled;
            SpriteRenderer sr = pc1.GetComponent<SpriteRenderer>();
            if (sr.flipX) sr.flipX = false;
        }
	}
}
