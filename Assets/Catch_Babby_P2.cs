using UnityEngine;
using System.Collections;

public class Catch_Babby_P2 : MonoBehaviour {
    private bool p2;
    private p2_blanket blank2;

    void Start()
    {
        blank2 = FindObjectOfType<p2_blanket>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        p2 = blank2.hinge2.enabled;
        if (col.gameObject.tag == "Babby")
        {
            if (!p2 && col.gameObject.GetComponent<Babby>().get_bouncy() != 0)
            {
                ScoreKeeper sk = ScoreKeeper.Instance;
                sk.addBabyScore(sk.babiesCaught + 1);
                Destroy(col.gameObject);
                Debug.Log("Player 2 Caught the Babby");
            }
        }
    }
}
