﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Vector3 direction = Vector3.zero;
    public float speed = 10f;
    public GameObject spawnPoint = null;
    private Dictionary<Item.VegetableType, int> ItemInventory = new Dictionary<Item.VegetableType, int>();

    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();

        foreach (Item.VegetableType item in System.Enum.GetValues(typeof(Item.VegetableType)))
        {
            ItemInventory.Add(item, 0);
        }
    }


    private void AddToInventory(Item item)
    {
        ItemInventory[item.typeOfVeggie]++;
    }


    private void PrintInventory()
    {
        string output = "";

        foreach(KeyValuePair<Item.VegetableType, int> kvp in ItemInventory)
        {
            output += string.Format("{0} {1}", kvp.Key, kvp.Value);
        }
        Debug.Log(output);
    }


    void Update()
    {
        float horMove = Input.GetAxis("Horizontal");
        float verMove = Input.GetAxis("Vertical");

        direction = new Vector3(horMove, 0, verMove);
    }


    void FixedUpdate()
    {
        rbPlayer.AddForce(direction * speed, ForceMode.Force);

        if (transform.position.z > 40)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 40);
        }
        else if (transform.position.z < -40)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -40);
        }
    }


    private void Respawn()
    {
        rbPlayer.MovePosition(spawnPoint.transform.position);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("item"))
        {
            Item item = other.gameObject.GetComponent<Item>();
            AddToInventory(item);
            PrintInventory();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("hazard"))
        {
            Respawn();
        }
    }



}