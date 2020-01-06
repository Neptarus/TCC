using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reality : MonoBehaviour {

	static float wait = 15f;
	[SerializeField] GameObject sides;
	[SerializeField] GameObject roof;
	[SerializeField] GameObject bumperF;
	[SerializeField] GameObject bumperB;
	[SerializeField] GameObject Wheels1;
	[SerializeField] GameObject Wheels2;
	[SerializeField] GameObject Wheels3;
	[SerializeField] GameObject Wheels4;

	void Start () {
		StartCoroutine(destroy());
	}
	
	IEnumerator destroy(){
		yield return new WaitForSeconds(wait);
		Destroy(sides);
		Destroy(roof);
		yield return new WaitForSeconds(wait);
		Destroy(bumperB);
		Destroy(bumperF);
		Destroy(Wheels1);
		Destroy(Wheels2);
		Destroy(Wheels3);
		Destroy(Wheels4);
		yield return new WaitForSeconds(wait);
	}
}
