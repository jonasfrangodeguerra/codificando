using UnityEngine;

public class Coletável : MonoBehaviour
{
 public string nomeMoeda;
 public int valorMoeda;
 public bool podeColetar;


    public void Coletar()
    {
        if (podeColetar)
        {
            Debug.Log("Você coletou " + nomeMoeda + " no valor de " + valorMoeda);
        }
        else
        {
            Debug.Log("Você não pode coletar " + nomeMoeda);
        }
    }


}
