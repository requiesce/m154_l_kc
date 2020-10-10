using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Patrol : MonoBehaviour
{   /// ?

    /*Graph graph = new Graph();
    int currentWP = 0;
    GameObject currentNode;
    int speed = 8;
    int rotationSpeed = 5;
    float accuracy = 1;

    void CreateBiPath(string a, string b)
    {
        GameObject w1 = GameObject.Find(a);
        GameObject w2 = GameObject.Find(b);
        if(w1 && w2) //if both objs exist
        {
            // create edges btw waypoints in both directions
            {
                graph.AddEdge(w1, w2);
                graph.AddEdge(w2, w1);
            }
        }
    }

    // use for initialisation
    private void Start()
    {
            GameObject[] gos;
            gos = GameObject.FindGameObjectsWithTag("waypoint");
            foreach (GameObject go in gos)
            {
                graph.AddNode(go, true, true);
            }
            CreateBiPath("Sphere3","Sphere2");
            CreateBiPath("Sphere2", "Sphere1");
            CreateBiPath("Sphere1", "Sphere4");
            CreateBiPath("Sphere3", "Sphere4");
            CreateBiPath("Sphere4", "Sphere5");
            CreateBiPath("Sphere5", "Sphere6");
            CreateBiPath("Sphere6", "Sphere7");
            CreateBiPath("Sphere7", "Sphere8");
            CreateBiPath("Sphere8", "Sphere9");
            CreateBiPath("Sphere9", "Sphere10");
            CreateBiPath("Sphere10", "Sphere11");
            CreateBiPath("Sphere11", "Sphere12");
            CreateBiPath("Sphere12", "Sphere13");
            CreateBiPath("Sphere13", "Sphere14");
            CreateBiPath("Sphere14", "Sphere15");
            CreateBiPath("Sphere15", "Sphere17");

            currentNode = GameObject.Find("Sphere2");
    }

    private void Update()
    {
        graph.debugDraw();
    }*/
}
