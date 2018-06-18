﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryOperator : MonoBehaviour {

    public GameObject backPanel;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject icon1;
    public GameObject icon2;
    public GameObject icon3;
    public GameObject icon4;

    /* public GameObject item5;
    public GameObject item6;
    public GameObject item7;
    public GameObject item8; */

    public Sprite iconRock;
    public Sprite iconBall;
    public Sprite iconDrone;
    public Sprite iconBook;
    public Sprite iconRef;

    private bool item1Active = false;
    private bool item2Active = false;
    private bool item3Active = false;
    private bool item4Active = false;
    private bool showing = false;


    private int index = 0;

	// Use this for initialization
	void Start () {
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void addItem(int ID, string name){

        // 100001 = rock
        // 100002 = ball
        // 100003 = drone
        // 100004 = book
        
        switch (ID)
        {
            case 100001: // rock
                // do something
                iconRef = iconRock;
                break;
            case 100002: // soccer ball
                iconRef = iconBall;
                break;
            case 100003:
                iconRef = iconDrone;
                break;
            case 100004:
                iconRef = iconBook;
                break;
            default:
                break;
                
        }

        switch (index)
        {
            case 0:
                item1Active = true;
                item1.GetComponentInChildren<Text>().text = name;
                icon1.GetComponent<Image>().sprite = iconRef;
                break;
            case 1:
                item2Active = true;
                item2.GetComponentInChildren<Text>().text = name;
                icon2.GetComponent<Image>().sprite = iconRef;
                break;
            case 2:
                item3Active = true;
                item3.GetComponentInChildren<Text>().text = name;
                icon3.GetComponent<Image>().sprite = iconRef;
                break;
            case 3:
                item4Active = true;
                item4.GetComponentInChildren<Text>().text = name;
                icon4.GetComponent<Image>().sprite = iconRef;
                break;
            default:
                break;
        }

        index += 1;

        if (showing){
            show();
        }


    }

    public void show(){

        showing = true;

        backPanel.SetActive(true);

        if (item1Active == true){
            item1.SetActive(true);
        }
        if (item2Active == true)
        {
            item2.SetActive(true);
        }
        if (item3Active == true)
        {
            item3.SetActive(true);
        }
        if (item4Active == true)
        {
            item4.SetActive(true);
        }

    }

    public void hide(){

        showing = false;
        backPanel.SetActive(false);
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
        item4.SetActive(false);


    }

    public void removeItem(){
        
    }

}