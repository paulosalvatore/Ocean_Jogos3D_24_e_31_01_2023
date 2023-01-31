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
        // Pegamos o primeiro objeto filho do Cannon, que no caso é o objeto Bullet
        // Como os filhos de objetos ficam conectados a seu transform, pegamos
        // o GameObject do objeto Bullet
        var bulletOriginal = transform.GetChild(0).gameObject;
        // print(bulletOriginal);

        // Fazer uma cópia do bulletOriginal
        // Para isso, usamos o método Instantiate, que recebe um objeto qualquer e duplica esse objeto
        // Esse objeto recebido pode ser tanto um Prefab (que está na aba Projects) ou um GameObject,
        // que está na cena.
        // Assim que o Instantiate é executado, recebemos como retorno o objeto que foi clonado
        // Quando queremos instanciar objetos na mesma posição e rotação do que o original, precisamos
        // informar esses valores

        var bulletClone = Instantiate(
            bulletOriginal,
            bulletOriginal.transform.position,
            bulletOriginal.transform.rotation
        );

        // Utilizando o objeto clonado, executamos o SetActive(true), para que o objeto fique visível
        // na cena
        bulletClone.SetActive(true);

        // print("GenerateBullet"); // Sugar Syntax -> Unity -> Debug.Log -> Console.WriteLine

        // Console.WriteLine("Teste"); // C#

        // Debug.Log("Teste"); // Unity
        // Debug.LogWarning(); // Unity -> envia como Warning (amarelo)
        // Debug.LogError(); // Unity -> envia como Error (vermelho)
    }
}
