using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInterface
{
    /*
    - Método Geral para todos o NPCs. O Comerciante, o Alidado e o Inimigo herdam este método.
    - O método deve o VIRTUAL, pois ele será alterado nos scripts que herdam NPC.
    */

    public virtual void Interagir()
    {

    }
}
