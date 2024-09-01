using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float timeToSpawn = 1.5f;
    public List<GameObject> obsPref; 
    public int r; 
    void Start () 
    { 
        Spawn (); 
    } 
    void Spawn() 
    { 
        r = Random. Range (8, obsPref.Count);
        Instantiate (obsPref [r], transform.position, transform.rotation);
        Invoke ("Spawn", timeToSpawn);
    }
}

