using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpiderEndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     StartCoroutine(Wait());   
    }

    IEnumerator Wait() {
        yield return new WaitForSeconds(9.7f);
        yield return new WaitForSeconds(14.7f);
        yield return new WaitForSeconds(14.7f);
        yield return new WaitForSeconds(30f);
        SceneManager.LoadScene(0);
    }
}
