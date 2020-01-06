using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour {
    [SerializeField] Animation anim;
    private bool waiting = false;

    public void LoadSpider()
    {  
        anim.Play("Blink");
        StartCoroutine(wait(1));
    }

    public void LoadHeight()
    {
        anim.Play("Blink");
        StartCoroutine(wait(2));
    }

    public void LoadCar()
    {
        anim.Play("Blink");
        StartCoroutine(wait(5));
    }

    IEnumerator wait(int id){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(id);
    }
}
