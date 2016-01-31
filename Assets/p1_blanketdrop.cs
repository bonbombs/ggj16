﻿using UnityEngine;
using System.Collections;

public class p1_blanketdrop : MonoBehaviour {

    public HingeJoint2D hinge;
	
    // Use this for initialization
	void Start ()
    {
       hinge = GetComponent<HingeJoint2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            hinge.enabled = !hinge.enabled;
        }
	}
}
