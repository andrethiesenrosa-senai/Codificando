using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int vida;
    public int dano;
    public float velocidade;

    public void Atacar()
    {
        Debug.Log("Ataquei com " + dano);
    }
}
