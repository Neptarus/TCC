using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web : MonoBehaviour {
    [SerializeField] GameObject Spider;
    Vector3 posSpider;
    Vector3 posAnchor;
    float posY = 0.005f;

    void Awake()
    {
        posAnchor = new Vector3(789.051f, 233.58f, 188.72f);
        GetComponent<LineRenderer>().SetPosition(1, posAnchor);
    }

    // Update is called once per frame
    void Update () {
        if (this.transform.position.y >= 229.8f)
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y - posY, transform.position.z);
            posSpider = new Vector3(transform.position.x, transform.position.y - posY, transform.position.z);
            GetComponent<LineRenderer>().SetPosition(0, posSpider);
        }
	}
}