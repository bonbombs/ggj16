using UnityEngine;
using System.Collections;

public class BabySpawnController : MonoBehaviour {
    //heavy, light, cute, bomb

    public GameObject[] babyPrefabs;

    [SerializeField]
    float spawnTime = 1.0f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBaby", spawnTime, spawnTime);   
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnBaby ()
    {
        //Do throwing animation first, yield a few seconds
        int num = Random.Range(0, babyPrefabs.Length);
        Debug.Log(num);
        GameObject randomBaby = babyPrefabs[num];
        Instantiate(randomBaby, new Vector3((16f * Random.value - 8f), 5f, 0f), randomBaby.transform.rotation);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Babby")
            Destroy(collision.gameObject);
    }
}
