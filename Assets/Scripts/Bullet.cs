using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    /*
    Para movimentar o objeto (GameObject), faremos o seguinte:
      1. No Start(), pegar o componente Rigidbody do GameObject
      2. No Start(), adicionar uma força ao componente, usando AddForce()
      Como o AddForce() precisa de uma direção (direction), vamos criar uma variável que será
      configurada a partir da Unity.
      Além disso, também teremos uma variável para configurar a intensidade da força (forceSpeed) que é adicionada
      Portanto, o movimento do projétil será definido a partir de:
      direction * forceSpeed
    */

    // Propriedade é uma variável que está declarada dentro da classe
    // Quando a variável está declarada dentro de métodos ou declarações mais simples,
    // o nome é apenas "variável"

    // Tipo // Nome
    // float teste;

    // Modificador de acesso // Tipo // Nome
    // private float teste2;
    // public float teste3;
    // internal float teste3;

    public Vector3 direction = Vector3.up; // Vector3.up é equivalente a new Vector3(0, 1, 0)
    public float forceSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(direction * forceSpeed);

        // AddForce -> Adiciona uma força em uma determinada direção, levando em consideração o eixo global
        // AddRelativeForce -> Adiciona uma força em uma determinada direção, levando em consideração o eixo local
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
