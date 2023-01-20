using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriangleMesh : MonoBehaviour
{
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
        //transform.position = new Vector3(0, 0, 0);
    }

    void CreateShape()
    {

        vertices = new Vector3[]
        {/* work !!
          * 
            new Vector3(-0.5f,0,0),
            new Vector3(0.5f,0,0),
            // Formule d'un triangle équilatéral C = A + (2 * (B-A))/sqrt(3)
            new Vector3(0f,0.866f,0)
            */

            new Vector3(-0.5f,-0.4f,0),
            new Vector3(0.5f,-0.4f,0),
            // Formule d'un triangle équilatéral C = A + (2 * (B-A))/sqrt(3)
            new Vector3(0f,0.466f,0)
          
        };
        triangles = new int[]
        {
            0,1,2
        };

    }
    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
