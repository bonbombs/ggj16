using UnityEngine;
using System.Collections;

public class Catch_Babby_P1 : MonoBehaviour {
    private bool p1;
    private p1_blanketdrop blank1;

    void Start()
    {
        blank1 = FindObjectOfType<p1_blanketdrop>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        p1 = blank1.hinge.enabled;
        if (col.gameObject.tag == "Babby")
        {
            if (!p1 && col.gameObject.GetComponent<Babby>().get_bouncy() != 0)
            {
                Destroy(col.gameObject);
                Debug.Log("Player 1 Caught the Babby");
            }
        }
    }
}
