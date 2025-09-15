using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour
{


    public GameObject[] objects;

    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        

        Instantiate(objects[rand], transform.position,Quaternion.identity);
    }
}
