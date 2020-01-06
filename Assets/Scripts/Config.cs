using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Config : MonoBehaviour {
    private Scene scene;
    void Awake(){
        Application.targetFrameRate = 60;
    }

    void Start(){
        scene = SceneManager.GetActiveScene();
    }
	void Update(){
        if(Input.GetKeyDown(KeyCode.B) || GvrPointerInputModule.Pointer.Triggering == true){
            if(scene.buildIndex != 0){
                SceneManager.LoadScene(0);
            }
        }
    }
}