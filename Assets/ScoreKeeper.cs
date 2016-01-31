using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    public int babiesCaught
    {
        get { return m_babiesCaught; }
        set { addBabyScore(value); }
    }

    public float currentCrowd
    {
        get { return m_currentCrowd; }
        set { updateMeter(value); }
    }

    [SerializeField]
    float maxCrowd;

    float maxHealth;
    [SerializeField]
    Text babyCount;
    [SerializeField]
    Image maxBar, currentBar;

    public static ScoreKeeper Instance { get; private set; }

    private float m_currentCrowd = 0;
    private int m_babiesCaught = 0;

	// Use this for initialization
	void Start () {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
        m_currentCrowd = maxCrowd / 2;
        currentBar.fillAmount = currentCrowd / maxCrowd;
    }

    // Update is called once per frame
    void Update () {
	    if(m_currentCrowd <= 0)
        {
            //GAME OVER
        }
	}

    public void addBabyScore(int newVal)
    {
        babyCount.text = newVal.ToString();
        m_babiesCaught = newVal;
        updateMeter(newVal + currentCrowd);
    }

    void updateMeter(float newVal)
    {
        if (newVal > maxCrowd) return;
        m_currentCrowd = newVal;
        currentBar.fillAmount = newVal / maxCrowd;
    }
}
