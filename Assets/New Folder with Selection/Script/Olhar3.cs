using UnityEngine;

public class Olhar3 : MonoBehaviour
{
    void LateUpdate()
    {
        // Faz o objeto rotacionar exatamente na mesma direção que a Main Camera está olhando
        if (Camera.main != null)
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }
}