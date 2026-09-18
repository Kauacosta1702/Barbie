using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca necessária para trocar de cena

public class PortalCristal : MonoBehaviour
{
    private bool jogadorPerto = false;

    void Update()
    {
        // Se o jogador estiver perto do cristal e apertar a tecla E
        if (jogadorPerto && Input.GetKeyDown(KeyCode.E))
        {
            TrocarDeCena();
        }
    }

    void TrocarDeCena()
    {
        // Pega o nome da cena em que o jogador está agora
        string cenaAtual = SceneManager.GetActiveScene().name;

        // Se estiver na SampleScene, vai para o Castelo
        if (cenaAtual == "SampleScene")
        {
            SceneManager.LoadScene("Castelo");
        }
        // Se estiver na cena do Castelo, vai para a cena de Créditos
        else if (cenaAtual == "Castelo")
        {
            SceneManager.LoadScene("Creditos"); // Certifique-se de que a cena de créditos se chama exatamente assim ou mude aqui
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se foi a Barbie/Player que encostou no cristal
        if (other.CompareTag("Player") || other.name.Contains("Barbie"))
        {
            jogadorPerto = true;
            Debug.Log("Pressione E para interagir com o cristal!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Quando o jogador se afasta do cristal
        if (other.CompareTag("Player") || other.name.Contains("Barbie"))
        {
            jogadorPerto = false;
        }
    }
}