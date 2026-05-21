using Unity.VisualScripting;
using UnityEngine;

public class Level : MonoBehaviour
{
 public int levelNumero;
 public bool podeEvoluir;
 public float xpParaEvoluir;

 public void Evoluir()
 {
     if (xpParaEvoluir >= 100)
     {
         podeEvoluir = true;
         levelNumero++;
         xpParaEvoluir = 0;
     }
     else
     {
         podeEvoluir = false;
     }


        if (podeEvoluir)
     {
         Debug.Log("Parabéns, você evoluiu para o nível " + levelNumero);
     }
     else
     {
         Debug.Log("Você ainda não pode evoluir, continue jogando para ganhar mais XP!");
     }
    
    
    }

   

}
