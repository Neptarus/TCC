using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equalizer : MonoBehaviour {
	[SerializeField] Camera posicao;

	void Start(){
		posicao.enabled = false;
		posicao.transform.position = new Vector3(0f,0f,0.08f);
		posicao.ResetWorldToCameraMatrix();
		posicao.ResetAspect();
		posicao.enabled = true;
	}

}
