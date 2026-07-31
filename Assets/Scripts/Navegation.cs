using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void CargarEscena()
    {
        
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
