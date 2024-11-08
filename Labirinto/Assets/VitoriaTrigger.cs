using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class VitoriaTrigger : MonoBehaviour
{    
    public string nomeCenaVitoria = "Vitoria";

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(nomeCenaVitoria);
        }
    }
}
