using UnityEngine;

public class dusmanlar : MonoBehaviour 
{
    public data data;
    public GameObject dusman;
    void Start()
    {
        dusman.GetComponent<Renderer>().material.color = data.renk;
        Debug.Log("d��man bil�isi " + "h�z� " + data.hiz + "skor " + data.skor);
    }
}
