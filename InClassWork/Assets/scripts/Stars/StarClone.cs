using UnityEngine;
using System.Collections;

public class StarClone : MonoBehaviour {

    public Transform[] spawnPoints;
    public Transform star;
    public float spawnFrequency = 1;
    public bool canSpawnStars = true;

    private int i = 0;

    IEnumerator SpawnStars()
    {
        while(canSpawnStars)
        {
            // This randomizes the value of i
            i = Random.Range(0, spawnPoints.Length - 1);
            Instantiate(star, spawnPoints[i].position, Quaternion.identity);
            yield return new WaitForSeconds(spawnFrequency);
            
        }
    }

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(SpawnStars());
	}
	

}
