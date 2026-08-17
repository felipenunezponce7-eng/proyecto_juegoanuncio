using UnityEngine;
using UnityEngine.SceneManagement;


public class LogicaBotones : MonoBehaviour
{
    

    public void Jugar(){
        SceneManager.LoadScene("Gameplay");
    }
}