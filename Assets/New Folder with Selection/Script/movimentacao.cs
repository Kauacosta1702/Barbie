using UnityEngine;

public class movimentacao : MonoBehaviour
{
    public float velocidade = 5f;
    public float velocidadeRotacao = 200f;
    private CharacterController controller;
    private Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * moveZ;
        controller.SimpleMove(move * velocidade);

        // Gira para os lados (esquerda e direita)
        if (moveX != 0)
        {
            transform.Rotate(0, moveX * velocidadeRotacao * Time.deltaTime, 0);
        }

        // Animação
        float currentSpeed = Mathf.Abs(moveZ) * velocidade;
        animator.SetFloat("velocidade", currentSpeed);
    }
}