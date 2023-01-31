using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    /*
    1. A cada X segundos, executa um método
    2. Ao executar o método, cria um projétil novo
    3. Assim que o projétil for criado, ativa o GameObject para que o movimento seja iniciado
    */

    public float initialDelay = 1f;

    public float repeatRate = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateBullet", initialDelay, repeatRate);
    }

    void GenerateBullet()
    {
        print("GenerateBullet");
    }
}
