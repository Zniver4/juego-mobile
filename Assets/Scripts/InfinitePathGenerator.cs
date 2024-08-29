using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePathGenerator : MonoBehaviour
{
    public GameObject[] pathPrefabs; // Array de prefabs de los segmentos del camino
    public Transform player; // Referencia al jugador
    public float spawnDistance = 50f; // Distancia a la que se generarán nuevos segmentos
    private List<GameObject> activePaths = new List<GameObject>(); // Lista de segmentos activos
    private float zSpawn = 0f; // Posición Z donde se generará el próximo segmento

    void Start()
    {
        // Generar los primeros segmentos del camino
        for (int i = 0; i < 5; i++)
        {
            SpawnPath();
        }
    }

    void Update()
    {
        // Generar nuevos segmentos si el jugador se acerca al final del camino
        if (player.position.z - spawnDistance > zSpawn - (5 * spawnDistance))
        {
            SpawnPath();
            DeletePath();
        }
    }

    void SpawnPath()
    {
        GameObject path = Instantiate(pathPrefabs[Random.Range(0, pathPrefabs.Length)], transform.forward * zSpawn, transform.rotation);
        activePaths.Add(path);
        zSpawn += spawnDistance;
    }

    void DeletePath()
    {
        Destroy(activePaths[0]);
        activePaths.RemoveAt(0);
    }
}

