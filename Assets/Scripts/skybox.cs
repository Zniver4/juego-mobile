using System.Collections;
using UnityEngine;

public class Skybox : MonoBehaviour
{
    public Material[] skyboxes; // Array de materiales para el Skybox
    public float changeInterval = 5.0f; // Intervalo de cambio (en segundos)

    private int currentSkyboxIndex = 0;

    void Start()
    {
        // Establece el primer Skybox al inicio
        RenderSettings.skybox = skyboxes[currentSkyboxIndex];
        StartCoroutine(ChangeSkybox());
    }

    IEnumerator ChangeSkybox()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeInterval);

            currentSkyboxIndex = (currentSkyboxIndex + 1) % skyboxes.Length;
            RenderSettings.skybox = skyboxes[currentSkyboxIndex];
        }
    }
}


