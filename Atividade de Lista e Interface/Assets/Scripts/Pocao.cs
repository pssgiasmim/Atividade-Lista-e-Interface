using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocao : Item
{
    public override void Interagir()
    {
        Debug.Log("Voc� pegou a po��o");
    }

    public override void Consumir()
    {
        Debug.Log("Voc� tomou a po��o");
    }
}
