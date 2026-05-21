using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int damage;
    public int life;
    public float speed;

    public void Attack()
    {

        if (damage > 10)
        {
            Debug.Log("Inimigo usou ataque especial!");
        }
        else
        {
            Debug.Log("Inimigo atacou!");
        }

    }
}
