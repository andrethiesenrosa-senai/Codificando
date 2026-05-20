using UnityEngine;

public class NPC : MonoBehaviour
{
    public string nome;
    public bool interagivel;
    public int idade;

    void Start()
    {

    }

    public void Falar()
    {
        Debug.Log("Oi, meu nome é " + nome);
    }

}
