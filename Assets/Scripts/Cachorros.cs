using UnityEngine;

public class Cachorros : MonoBehaviour
{
    public string nome;
    public bool sono;

    
    private void Start()
    {
        Cachorros pitbul = new Cachorros();
        pitbul.nome = "Bob";
        pitbul.sono = true;
    }
}
