using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject sphere;
    //public Vector3 position;


    public void CreateOpbject() {
        if (sphere != null) {
            Instantiate(sphere, transform.position, Quaternion.identity);

        }
    }

    
}
