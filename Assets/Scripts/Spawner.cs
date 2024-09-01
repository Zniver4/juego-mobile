using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public List<GameObject> prefabsToSpawn;
    public Transform rightPosition;
    public Transform leftPosition;
    public float spawnInterval = 5f; // Tiempo en segundos antes de que se destruya el objeto y se genere uno nuevo

    private GameObject currentObject;

    void Start()
    {
        SpawnObject();
    }
 
    void SpawnObject()
    {
        // Si ya hay un objeto, destruirlo
        if (currentObject != null)
        {
            Destroy(currentObject);
        }

        // Generar un n�mero aleatorio para la posici�n, 0 o 1
        int randomSide = Random.Range(0, 2);
        Transform spawnPosition = randomSide == 0 ? rightPosition : leftPosition;

        // Generar un n�mero aleatorio para el prefab
        int randomPrefabIndex = Random.Range(0, prefabsToSpawn.Count);
        GameObject prefabToSpawn = prefabsToSpawn[randomPrefabIndex];

        // Instanciar el prefab en la posici�n determinada
        currentObject = Instantiate(prefabToSpawn, spawnPosition.position, spawnPosition.rotation);

        // Llamar a SpawnObject nuevamente despu�s de un intervalo de tiempo
        Invoke("SpawnObject", spawnInterval);
    }
}


