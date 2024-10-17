using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public List<GameObject> prefabsToSpawn;
    public Transform rightPosition;
    public Transform leftPosition;
    public float initialSpawnInterval = 5f; // Tiempo inicial en segundos
    private float spawnInterval;
    private GameObject currentObject;
    private float timeMultiplier = 1f; // Multiplicador de tiempo

    void Start()
    {
        spawnInterval = initialSpawnInterval;
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

        // Reducir el intervalo de spawn a medida que pasa el tiempo
        timeMultiplier *= 0.95f; // Ajusta este valor seg�n sea necesario
        spawnInterval = initialSpawnInterval * timeMultiplier;

        // Asegurarse de que el intervalo no sea menor a un m�nimo definido
        spawnInterval = Mathf.Max(spawnInterval, 1f); // Valor m�nimo de intervalo

        // Llamar a SpawnObject nuevamente despu�s de un intervalo de tiempo
        Invoke("SpawnObject", spawnInterval);
    }
}




