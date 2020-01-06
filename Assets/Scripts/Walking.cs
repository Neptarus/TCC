using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Walking : MonoBehaviour {
	static float wait = 15f;
	static Vector3 tele1 = new Vector3(23.6f, 2.98f, -15.2f);
	static Vector3 tele2 = new Vector3(23.6f, 2.98f, -30.4f);
	// Use this for initialization
	void Start () {
		StartCoroutine(maybe());
	}
	
	IEnumerator maybe(){
		yield return new WaitForSeconds(wait);
		transform.position = tele1;
		yield return new WaitForSeconds(wait);
		transform.position = tele2;
		yield return new WaitForSeconds(wait);
		SceneManager.LoadScene(0);
	}
}
