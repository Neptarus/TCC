using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roof : MonoBehaviour {

	void Start () {
        StartCoroutine(Load());
    }
	
    IEnumerator Load()
    {
		yield return new WaitForSeconds(15f);
    transform.position = new Vector3 (0f, 43.82f, 16.658f);
    yield return new WaitForSeconds(15f);
		SceneManager.LoadScene(4);
    }
}
