using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LabelResetter : MonoBehaviour
{ 
    [SerializeField]
    private TMP_Text tmpTextToUpdate;

    [SerializeField]
    private string Tonic = "C";

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        tmpTextToUpdate.text = Tonic;

    }
}