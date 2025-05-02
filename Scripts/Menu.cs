using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;  

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {

        SceneManager.LoadScene("Escenaprincipal"); 
    }
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
