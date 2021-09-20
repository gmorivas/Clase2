using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{

    public void CambiarEscena() {


        SceneManager.LoadScene(1);
    }

    public void CerrarJuego() {


        // solo funciona en binario, no en editor
        Application.Quit();
    }
}
