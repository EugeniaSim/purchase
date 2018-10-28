using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Viev : MonoBehaviour  {
    
    private Shop vievOfShop;
    public GameObject panel;


    private void Start()
    {
        for (int i = 0; i < vievOfShop.all.Count; i++)
        {
            Instantiate(panel);
        }

       // Resources.FindObjectsOfTypeAll<ScriptableObject>();
       // PrefabUtility.GetPrefabObject(panel);
       // AssetDatabase.LoadAllAssetRepresentationsAtPath(" ");
       // Debug.Log(vievOfShop.all.Count);
    }

    
    private void Update()
    {
           Debug.Log(vievOfShop.all.Count);
    }
}
