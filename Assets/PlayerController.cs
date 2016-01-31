using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private int playerNum;

    public bool isHoldingBlanket = true;

    private string playerAxis;
    private Animator animator;
    private SpriteRenderer sr;
    private Text label;
    private Vector3 labelOffset = new Vector3(0, 1.5f);
    [SerializeField]
    float speed = 5.0f;

    private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
        playerAxis = "P" + playerNum + "_Horizontal";
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        Text[] labels = FindObjectsOfType<Text>();
        foreach (Text l in labels){
            if (l.name.Contains(playerNum.ToString())) label = l;
        }
        label.transform.position = transform.position + labelOffset;
    }
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis(playerAxis);
        if (horizontal != 0) animator.SetBool("isMoving", true);
        else animator.SetBool("isMoving", false);
        moveDirection = new Vector3(horizontal, 0, 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        transform.position += moveDirection * Time.deltaTime;
        label.transform.position = transform.position + labelOffset;

        if (!isHoldingBlanket)
        {
            animator.SetBool("isCatching", true);
            if (horizontal > 0) sr.flipX = false;
            else if (horizontal < 0) sr.flipX = true;
        }
        else animator.SetBool("isCatching", false);

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
