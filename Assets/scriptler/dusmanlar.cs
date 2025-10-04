using UnityEngine;

public class dusmanlar : MonoBehaviour 
{
    public data data;
    public GameObject dusman;
    void Start()
    {
        dusman.GetComponent<Renderer>().material.color = data.renk;
        Debug.Log("düþman bilðisi " + "hýzý " + data.hiz + "skor " + data.skor);
    }
}
