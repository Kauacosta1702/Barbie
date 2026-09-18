using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para trocar de cena
using System.Collections;         // Necessário para usar corrotinas (esperar segundos)

public class VoltarMenu2000 : MonoBehaviour
{
    public float tempoDeEspera = 10f; // Tempo em segundos antes de voltar ao menu
    public string nomeCenaMenu = "Menu"; // Mude para o nome exato da cena do seu Menu Principal

    void Start()
    {
        // Inicia a contagem regressiva assim que a cena abre
        StartCoroutine(EsperarEVoltar());
    }

    IEnumerator EsperarEVoltar()
    {
        // Espera 10 segundos (ou o tempo configurado)
        yield return new WaitForSeconds(tempoDeEspera);

        // Carrega a cena do menu principal
        SceneManager.LoadScene(nomeCenaMenu);
    }
}