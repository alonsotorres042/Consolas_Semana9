using UnityEngine;
using TMPro;

public class FPSCounterTMP : MonoBehaviour
{
    public TextMeshProUGUI fpsText;  // Referencia al componente TMP en la UI

    float deltaTime = 0.0f;

    void Update()
    {
        // Suavizamos la lectura del deltaTime
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        // Calculamos FPS
        float fps = 1.0f / deltaTime;

        // Actualizamos el texto en TMP Pro
        fpsText.text = Mathf.Ceil(fps).ToString() + " FPS";
    }
}
