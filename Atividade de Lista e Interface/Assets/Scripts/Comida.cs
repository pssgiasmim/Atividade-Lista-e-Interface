using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida : Item
{
    public override void Interagir()
    {
        Debug.Log("Voc� pegou a comida");
    }

    public override void Consumir()
    {
        Debug.Log("Voc� comeu a comida");
    }
}
