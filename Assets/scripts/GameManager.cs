using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public List<Inimigos> inimigoList = new();

    private void Start()
    {
       for (int i = 0; i < inimigoList.Count; i++)
        {
            inimigoList[i].Attack();
        }
    }

}
