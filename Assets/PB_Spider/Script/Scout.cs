using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Scout : MonoBehaviour {
    public NavMeshAgent spider;
    [SerializeField] List<GameObject> Path;
    int i = 0;
   

	// Use this for initialization
	void Awake () {
        // codigo necessario para inicializacao do NavMesh
        spider = GetComponent<NavMeshAgent>();
        spider.SetDestination(Path[i].transform.position);
    }
}
