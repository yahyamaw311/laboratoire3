//using UnityEngine;

//public class HealthBarManager : MonoBehaviour

//{

//    public HealthBar healthBar; // R�f�rence � la barre de sant� (assurez-vous qu'elle est assign�e dans l'inspecteur)

//    private float currentHealth;

//    private float maxHealth = 100f;

//    void Start()

//    {

//        currentHealth = maxHealth;

//        healthBar.SetMaxHealth(maxHealth); // Initialiser la barre de sant� avec la valeur maximale

//        Debug.Log("Sant� initialis�e � : " + currentHealth); // V�rifiez que la sant� est bien initialis�e

//    }

//    void Update()

//    {

//        foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))

//        {

//            if (Input.GetKey(vKey))

//            {

//                Debug.Log("Touche d�tect�e : " + vKey);
//                TakeDamage(10);

//            }

//        }

//    }

//    // Fonction pour infliger des d�g�ts au joueur

//    public void TakeDamage(float damageAmount)

//    {

//        currentHealth -= damageAmount;

//        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Limiter la sant� entre 0 et la sant� max

//        Debug.Log("D�g�ts re�us. Sant� actuelle : " + currentHealth); // V�rifiez la sant� apr�s avoir pris des d�g�ts

//        healthBar.SetHealth(currentHealth); // Mettre � jour l'interface utilisateur de la barre de sant�

//    }

//}


using UnityEngine;

public class HealthBarManager : MonoBehaviour
{
    public HealthBar healthBar; // R�f�rence � la barre de sant�

    private float currentHealth;
    private float maxHealth = 100f;

    void Start()
    {
        Debug.Log("D�marrage du script HealthBarManager"); // Debug pour v�rifier que Start est bien appel�
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); // Initialiser la barre de sant� avec la valeur maximale
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("insect"))
        {
            Debug.Log("Fl�che haut appuy�e, inflige 10 points de d�g�ts");
            TakeDamage(10);
        }
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Limiter la sant� entre 0 et la sant� max
        Debug.Log("Sant� actuelle apr�s d�g�ts : " + currentHealth); // V�rifier que la sant� est correctement calcul�e
        healthBar.SetHealth(currentHealth); // Appeler la mise � jour de la barre de sant�
    }
}
