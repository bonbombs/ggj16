using UnityEngine;
using System.Collections;

public class Launch_Babby : MonoBehaviour {
    private bool p1;
    private bool p2;
    private p1_blanketdrop blank1;
    private p2_blanket blank2;

    void Start()
    {
        blank1 = FindObjectOfType<p1_blanketdrop>();
        blank2 = FindObjectOfType<p2_blanket>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        p1 = blank1.hinge.enabled;
        p2 = blank2.hinge2.enabled;
        if (col.gameObject.tag == "Babby")
        {
            if (p1 && p2)
            {
                col.gameObject.GetComponent<Babby>().set_bouncy(col.gameObject.GetComponent<Babby>().get_bouncy() + 1);
                col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
            }
        }
    }
}
