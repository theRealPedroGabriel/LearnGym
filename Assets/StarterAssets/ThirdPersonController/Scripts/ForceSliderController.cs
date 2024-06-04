using StarterAssets;
using UnityEngine;
using UnityEngine.UI;

public class ForceSliderController : MonoBehaviour
{
    public Slider forceSlider;
    public ThirdPersonController playerController;

    void Start()
    {
        if (playerController != null && forceSlider != null)
        {
            forceSlider.value = playerController.exerciseForce / 100f; // Configura o valor inicial do slider
        }
    }

    void Update()
    {
        if (playerController != null && forceSlider != null)
        {
            forceSlider.value = playerController.exerciseForce / 100f; // Atualiza o valor do slider a cada frame
        }
    }
    public void UpdateSliderValue(float value)
    {
        if (forceSlider != null)
        {
            forceSlider.value = value;
        }
    }
}