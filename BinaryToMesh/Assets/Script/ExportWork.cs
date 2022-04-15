using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor.Formats.Fbx.Exporter;
#endif
using System.IO;
using Unity.Collections;


public class ExportWork : MonoBehaviour
{   

        //exportlanacagı path    
        string path2= @"C:\Unity_Projeler\s2bimJsonToMesh\BinaryToMesh\Assets\Tests";

    public Object obj;    
    public void ExportGameObject(Object objects) //export a object
    {   
        Debug.Log(path2);
        string filePath = Path.Combine(path2, objects.name+".fbx");
        ModelExporter.ExportObject(filePath, objects);
        Debug.Log("exportlandı.");
        
    }
    public void ExportGameObjects( List<GameObject> listOfGameObjects)//export list of obj
    {
    string filePath = Path.Combine(path2, "Meshes.fbx");
    Object[] arrayOfGameObjects = listOfGameObjects.ToArray();
    ModelExporter.ExportObjects(filePath, arrayOfGameObjects);
    }



    
    void Update()
    {
        
        if (Input.GetMouseButtonDown(2)){
            ExportGameObject(obj);

        }
    }
}
