using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Apartment : MonoBehaviour {
    
	void Start () {
        StartCoroutine(Load());
    }
	
    IEnumerator Load()
    {
        yield return new WaitForSeconds(15f);
        SceneManager.LoadScene(3);
    }
}
