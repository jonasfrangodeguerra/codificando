using UnityEngine;

public class NPCs : MonoBehaviour
{
    public string npcName;
    public bool isFriendly;
    public int age;
    private void Start()
    {
        NPCs roberto = new NPCs();
        roberto.age = 30;
        roberto.isFriendly = true;
        roberto.npcName = "Roberto";


        NPCs julia = new NPCs();
        julia.name = "Julia";
        julia.age = 18;
        julia.isFriendly = false;
    
    
    
    }


}
