using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
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

        // Generar un número aleatorio para la posición, 0 o 1
        int randomSide = Random.Range(0, 2);
        Transform spawnPosition = randomSide == 0 ? rightPosition : leftPosition;

        // Generar un número aleatorio para el prefab
        int randomPrefabIndex = Random.Range(0, prefabsToSpawn.Count);
        GameObject prefabToSpawn = prefabsToSpawn[randomPrefabIndex];

        // Instanciar el prefab en la posición determinada
        currentObject = Instantiate(prefabToSpawn, spawnPosition.position, spawnPosition.rotation);

        // Mover el prefab instanciado
        StartCoroutine(MovePrefab(currentObject));

        // Llamar a SpawnObject nuevamente después de un intervalo de tiempo
        Invoke("SpawnObject", spawnInterval);
    }

    IEnumerator MovePrefab(GameObject instance)
    {
        float duration = 5.0f; // Duración del movimiento en segundos
        Vector3 startPosition = instance.transform.position;
        Vector3 endPosition = new Vector3(0, 0, 10); // Nueva posición, ajusta según tus necesidades

        float elapsedTime = 0;
        while (elapsedTime < duration)
        {
            instance.transform.position = Vector3.Lerp(startPosition, endPosition, (elapsedTime / duration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        instance.transform.position = endPosition;
    }
}



