using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink2 : MonoBehaviour {
[SerializeField] new Animation animation;
	// Use this for initialization
	void Start () {
        StartCoroutine(Eyes());   
	}
	

    IEnumerator Eyes() {
        yield return new WaitForSeconds(14.7f);
        animation.Play("Blink");
        yield return new WaitForSeconds(14.7f);
        animation.Play("Blink");
    }
}
