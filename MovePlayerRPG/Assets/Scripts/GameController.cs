using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instancia;
    [SerializeField] Transform player;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) GameObject.Destroy(this);
    }

    public Transform getPlayer()
    {
        return player;
    }
}
