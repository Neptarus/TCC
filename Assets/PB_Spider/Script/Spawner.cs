using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour {
    // lista de prefabs de aranhas
    [SerializeField] List<GameObject> Spiders;
    int i = 0;
    int j = 0;
    // vector3 com posições randomicas
    Vector3 position;
    Vector3 Scout;

     void Awake()
    {
        Scout = new Vector3(783.22f, 225.51f, 200f);
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(10f);  //Espera 10 segundos antes de instanciar a primeira aranha
        var spider = Instantiate(Spiders[i], Scout, Quaternion.identity);
        Destroy(spider, 15f); //Destroi a aranha 30 segundos depois de instanciada para alivio do programa 
        yield return new WaitForSeconds(15f); //Espera 30 segundos para a aranha sair da casa
        for (j = 0; j < 5; j++)
        {
            position = new Vector3(Random.Range(777f, 794.0f), 225.7f, Random.Range(183f, 211.0f));
            i = Random.Range(1, 11);
            spider = Instantiate(Spiders[i], position, Quaternion.identity);
            Destroy(spider, 15f); 
            position = new Vector3(778f, Random.Range(225f, 232.0f), Random.Range(183f, 210.0f));
            i = Random.Range(11, 21);
            spider = Instantiate(Spiders[i], position, Quaternion.identity);
            Destroy(spider, 15f); 
        }
        yield return new WaitForSeconds(15f);
        spider = Instantiate(Spiders[21], new Vector3(789.051f, 233f, 188.72f), Spiders[21].transform.rotation);
        Destroy(spider, 45f);
    }
}
