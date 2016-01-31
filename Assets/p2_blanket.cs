using UnityEngine;
using System.Collections;

public class p2_blanket : MonoBehaviour {

    public HingeJoint2D hinge2; 

	// Use this for initialization
	void Start ()
    {
        hinge2 = GetComponent<HingeJoint2D>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            hinge2.enabled = !hinge2.enabled;
        }
    }
}
