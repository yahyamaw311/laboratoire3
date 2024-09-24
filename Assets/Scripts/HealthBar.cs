using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;

    // Fonction pour initialiser la barre de sant� � la valeur maximale
    public void SetMaxHealth(float maxHealth)
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = maxHealth;
    }

    // Utilise une Coroutine pour mettre � jour progressivement la barre de sant�
    public void SetHealth(float health)
    {
        StartCoroutine(SmoothHealthTransition(health));
    }

    // Coroutine pour animer la transition de la barre de sant�
    private IEnumerator SmoothHealthTransition(float targetHealth)
    {
        while (Mathf.Abs(healthSlider.value - targetHealth) > 1)
        {
            healthSlider.value = Mathf.Lerp(healthSlider.value, targetHealth, Time.deltaTime * 5);
            yield return null; // Attendre le frame suivant avant de continuer la boucle
        }
        healthSlider.value = targetHealth;
        Canvas.ForceUpdateCanvases(); // Assurez-vous que le Canvas est � jour
    }
}
