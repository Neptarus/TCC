using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spider : MonoBehaviour {
    public NavMeshAgent spider;
    [SerializeField] List<GameObject> Path;
    int i = 0;
    int Counter = 0;

    // Use this for initialization
    void Awake()
    {
        // codigo necessario para inicializacao do NavMesh
        spider = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Aranha andara pela casa até o Counter chegar até 5, depois saira da casa
        if (Counter < 2 && spider.hasPath == false)
        {
            spider.SetDestination(Path[i].transform.position);
            i++;
            Counter++;
        }
        if (Counter == 2 && spider.hasPath == false)
        {
            spider.SetDestination(Path[i].transform.position);
        }
    }
}
