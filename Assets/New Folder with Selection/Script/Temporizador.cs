using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Biblioteca do TextMeshPro

public class Temporizador : MonoBehaviour
{
    public float tempoRestante = 180f; // 3 minutos em segundos (3 * 60 = 180)
    public TextMeshProUGUI textoTemporizador; // Arraste o texto da UI aqui
    private bool tempoEsgotado = false;

    void Update()
    {
        if (tempoEsgotado) return;

        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime; // Diminui o tempo conforme o jogo roda
            AtualizarTextoRelogio(tempoRestante);
        }
        else
        {
            tempoRestante = 0;
            tempoEsgotado = true;
            IrParaTelaDerrota();
        }
    }

    void AtualizarTextoRelogio(float tempoEmSegundos)
    {
        if (textoTemporizador != null)
        {
            int minutos = Mathf.FloorToInt(tempoEmSegundos / 60);
            int segundos = Mathf.FloorToInt(tempoEmSegundos % 60);

            // Formata o texto para aparecer sempre com dois dígitos (ex: 02:05)
            textoTemporizador.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }
    }

    void IrParaTelaDerrota()
    {
        // Carrega a cena de derrota
        SceneManager.LoadScene("Perdeu67");
    }
}