using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColiderDetection : MonoBehaviour
{

    public GameObject enemy;

    private bool activado = false;

    private void OnTriggerEnter(Collider other){

        if(other.name == "Capsule"){

            Debug.Log("Alguien han entrado al Trigger");
            
            if(!activado){ // Activamos solo una vez la llamada a los objetos
                activado = true;

                enemy.SetActive(true); //Hacemos visible el audio
            }
        }
    }

    private void OnTriggerExit(Collider other){
        Debug.Log("ALguien ha salido");
    }
}
