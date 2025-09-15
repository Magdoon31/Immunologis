using UnityEngine;
using System.Collections;

public class TemplateGenerator : MonoBehaviour
{


    public GameObject[] objects;
        
    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        int[] angles = { 90, 180, 270 };
        int randomAngle = angles[Random.Range(0, angles.Length)];
        Quaternion randomRotation = Quaternion.Euler(0, 0, randomAngle);

        Instantiate(objects[rand], transform.position, randomRotation);
    }
}
