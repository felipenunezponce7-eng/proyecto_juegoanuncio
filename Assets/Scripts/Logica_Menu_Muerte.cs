using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logica_Menu_Muerte : MonoBehaviour
{
    
    public void Jugar()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void OnApplicationQuit()
    {
       Debug.Log( "cerrar jueguito");
    }
}
