using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocao : Item
{
    public override void Interagir()
    {
        Debug.Log("Você pegou a poção");
    }

    public override void Consumir()
    {
        Debug.Log("Você tomou a poção");
    }
}
