using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BackToTitle : MonoBehaviour {

    private Button button;

    // Use this for initialization
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { goToScene(); });
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void goToScene()
    {
        Application.LoadLevel("Title");
    }

}
