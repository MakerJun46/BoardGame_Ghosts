using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public GameObject this_Cell_Ghost;
    GameObject CanMove_PS;
    GameObject CanCatch_PS;
    public int cell_Index;

    private void Start()
    {
        CanMove_PS = transform.GetChild(0).gameObject;
        CanCatch_PS = transform.GetChild(1).gameObject;
    }

    public void TurnOff_PS()
    {
        CanMove_PS.SetActive(false);
        CanCatch_PS.SetActive(false);
    }

    public void TurnOn_CanMove()
    {
        CanMove_PS.SetActive(true);
    }

    public void TurnOn_CanCatch()
    {
        CanCatch_PS.SetActive(true);
    }

    public GameObject Ghost_inCell()
    {
        return this_Cell_Ghost;
    }
}
