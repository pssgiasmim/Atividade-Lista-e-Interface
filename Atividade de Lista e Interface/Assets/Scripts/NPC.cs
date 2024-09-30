using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInterface
{
    public virtual void Interagir()
    {

    }

    /*
    - M�todo Geral para todos o NPCs. O Comerciante, o Alidado e o Inimigo herdam este m�todo.
    - O m�todo deve ser o VIRTUAL, pois ele ser� alterado nos scripts que herdam NPC.
    */
}
