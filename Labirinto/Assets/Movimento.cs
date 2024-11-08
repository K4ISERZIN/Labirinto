using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 5f;  
    public float sensibilidade = 2f;  

    private float rotacaoX = 0f;  

    void Update()
    {
        // Movimentação com as teclas WASD
        float movimentoHorizontal = Input.GetAxis("Horizontal");  
        float movimentoVertical = Input.GetAxis("Vertical");  

        Vector3 movimento = new Vector3(movimentoHorizontal, 0f, movimentoVertical);
        transform.Translate(movimento * velocidade * Time.deltaTime, Space.World);  

        // Rotação do mouse (olhar ao redor)
        rotacaoX -= Input.GetAxis("Mouse Y") * sensibilidade;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);  

        float rotacaoY = Input.GetAxis("Mouse X") * sensibilidade;

        // Aplica as rotações no personagem
        Camera.main.transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        transform.Rotate(0f, rotacaoY, 0f);
    }
}
