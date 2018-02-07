using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFocus : MonoBehaviour {

    private ClaireMovement MoveClaire;
    private ThomasMovement MoveThomas;

    private void Start()
    {
        MoveClaire = GetComponentInChildren<ClaireMovement>();
        MoveThomas = GetComponentInChildren<ThomasMovement>();
        
    }

    void StopClaire()
    {
        MoveClaire.enabled = false;
        MoveThomas.enabled = true;
    }

    void StopThomas()
    {
        MoveThomas.enabled = false;
        MoveClaire.enabled = true;
    }
}
