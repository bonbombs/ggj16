using UnityEngine;
using System.Collections;

public class Game_Over_Score : MonoBehaviour {

    private UnityEngine.UI.Text SavedBabbys;
    private int NumBabbys;

	// Use this for initialization
	void Start () {
        SavedBabbys = GameObject.Find("Score_Text").GetComponent<UnityEngine.UI.Text>();
        DontDestroyOnLoad(SavedBabbys);
        NumBabbys = PlayerPrefs.GetInt("Score");
        SavedBabbys.text = "You caught " + NumBabbys + " babies!";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
