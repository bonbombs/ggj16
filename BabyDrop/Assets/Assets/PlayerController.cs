using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public int playerNum;

    private string playerAxis;

    [SerializeField]
    float speed = 5.0f;

    private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
        playerAxis = "P" + playerNum + "_Horizontal";
    }
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis(playerAxis);
        moveDirection = new Vector3(horizontal, 0, 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        transform.position += moveDirection * Time.deltaTime;

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
