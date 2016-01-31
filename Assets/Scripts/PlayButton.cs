using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayButton : MonoBehaviour {

    private Button button;
    public string scene;

	// Use this for initialization
	void Start () {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { goToScene(); });
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void goToScene()
    {
        Debug.Log("Going to main level");
        Application.LoadLevel(scene);
    }
}
