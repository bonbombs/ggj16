using UnityEngine;
using System.Collections;

public class p2_blanket : MonoBehaviour {

    public HingeJoint2D hinge2;
    public GameObject p2;
    private PlayerController pc2;

	// Use this for initialization
	void Start ()
    {
        hinge2 = GetComponent<HingeJoint2D>();
        pc2 = p2.GetComponent<PlayerController>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            hinge2.enabled = !hinge2.enabled;
            pc2.isHoldingBlanket = hinge2.enabled;
            SpriteRenderer sr = pc2.GetComponent<SpriteRenderer>();
            if (sr.flipX) sr.flipX = false;
        }
    }
}
