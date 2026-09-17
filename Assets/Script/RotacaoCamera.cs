using UnityEngine;

public class RotacaoCamera : MonoBehaviour
{
    public Transform alvo; // Arraste a Barbie aqui no Inspector
    public float sensibilidadeMouse = 100f;
    private float rotacaoX = 0f;

    void Start()
    {
        // Oculta o cursor do mouse e o prende no centro da tela
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Pega o movimento do mouse
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadeMouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadeMouse * Time.deltaTime;

        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -30f, 60f); // Limita para não dar a volta completa para cima/baixo

        // Gira a câmera e o personagem juntos
        transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        if (alvo != null)
        {
            alvo.Rotate(Vector3.up * mouseX);
        }
    }
}