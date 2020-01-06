using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {
	void Start () {
        StartCoroutine(Load());
    }
	
    IEnumerator Load()
    {
		yield return new WaitForSeconds(15f);
    transform.position = new Vector3 (0f, 67.13f, 15.89f);
    yield return new WaitForSeconds(15f);
    SceneManager.LoadScene(0);
    }
}
