using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public int foundKeys = 0;
    private void Update()
    {

        // Vérifiez si l'objet qui est entré dans le trigger a le tag "Player"
        if (foundKeys == 3)
        {

            GetComponent<Animator>().enabled = true;
            


            // Exécutez l'action souhaitée, par exemple afficher un message
            Debug.Log("Le joueur est entré dans la zone de trigger!");

            // Vous pouvez également appeler une méthode ou changer l'état du jeu
            // Exemple : augmenter un score, terminer un niveau, etc.
            // IncreaseScore();
            // EndLevel();
        }
        }
}
