using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class onClickListener : MonoBehaviour {
    
    private Button myButton;
    private Renderer rnd;
    private Material myMaterial;
    /*
    private void onStart()
    {
        myButton.onClick.AddListener(() => buttonClick());    
    }*/
    public RawImage img;
    public GameObject buttonPrefab;
    public Transform buttonContainer;

    private void start()
    {
        Texture[] textures = Resources.LoadAll<Texture>("Tattoos");
        Debug.LogWarningFormat("tSize: " + textures.Length, GetType());

        foreach (Texture t in textures)
        {
            GameObject go = Instantiate(buttonPrefab) as GameObject;
            go.transform.SetParent(buttonContainer);
            go.GetComponent<RawImage>().texture = t;

            string tName = t.name;
            Debug.LogWarningFormat("tName: "+tName, GetType());

            go.GetComponent<Button>().onClick.AddListener(() => buttonClick());

        }
    }

    public void buttonClick()
    {
        myMaterial = Resources.Load("bookMaterial", typeof(Material)) as Material;
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        myButton = GameObject.Find(buttonName).GetComponent<Button>();
        Debug.LogWarningFormat("buttonName: "+buttonName, GetType());

        myMaterial.mainTexture = myButton.image.mainTexture;
    }

    public void clearButtonClick()
    {
        GameObject[] marker = GameObject.FindGameObjectsWithTag("marker");
        for (int i = 0; i < marker.Length; i++)
        {
            Destroy(marker[i].gameObject);
        }

    }
}
