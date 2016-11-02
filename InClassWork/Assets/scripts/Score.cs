using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Static.score = PlayerPrefs.GetInt("Score", 0);

        StartCoroutine(AddToScore());
	}
	
    IEnumerator AddToScore ()
    {
        Static.score++;
        yield return new WaitForSeconds(1);

        print(Static.score);

        StartCoroutine(AddToScore());
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", Static.score);
        print("Final Score: " + PlayerPrefs.GetInt("Score"));
        print("Game Over");

    }
}
