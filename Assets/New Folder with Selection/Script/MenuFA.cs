using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFA : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SairDoJogo()
    {
        Debug.Log("O jogo foi fechado.");
        Application.Quit();
    }
}