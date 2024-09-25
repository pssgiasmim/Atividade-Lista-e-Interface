using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida : Item
{
    public override void Interagir()
    {
        Debug.Log("Você pegou a comida");
    }

    public override void Consumir()
    {
        Debug.Log("Você comeu a comida");
    }
}
