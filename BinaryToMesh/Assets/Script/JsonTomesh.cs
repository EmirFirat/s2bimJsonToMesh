using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using Random = UnityEngine.Random;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

public class JsonTomesh : MonoBehaviour
{
    // Start is called before the first frame update
    
        Mesh mesh;
        MeshFilter filter;
    void Start()
    {
        mesh=new Mesh();
        filter=gameObject.GetComponent<MeshFilter>();
        filter.mesh=mesh;
        mesh.Clear();
        
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            readAndShow();
        }
    }

    public class mymesh{
        public Vector3[] myvertices;

        public Vector2[] myUV;
        public int[] mytriangles;
        public Vector3[] mynormals;
        public Vector4[] mytangents;
    }

    public void readAndShow(){
        String p=@"C:\Unity_Projeler\Uploads\myjson.txt";
        StreamReader reader = new StreamReader(p);
        String s=reader.ReadToEnd();
        reader.Close();
        mymesh m=JsonConvert.DeserializeObject<mymesh>(s);
        
        mesh.vertices=m.myvertices;
        
        mesh.uv=m.myUV;

        mesh.triangles=m.mytriangles;

        mesh.normals=m.mynormals;
        mesh.tangents=m.mytangents;
        Debug.Log("Okundu:");
        //mesh.RecalculateBounds();
        

        

    }

}
