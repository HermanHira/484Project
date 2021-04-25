using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour 
{
    public void Test(string buttonName)
    {
        switch (buttonName)
        {
        case "0":
            print (buttonName);
            break;
        case "1":
            print (buttonName);
            break;
	case "2":
            print (buttonName);
            break;
	case "3":
            print (buttonName);
            break;
	case "4":
            print (buttonName);
            break;
	case "5":
            print (buttonName);
            break;
	case "6":
            print (buttonName);
            break;
	case "7":
            print (buttonName);
            break;
	case "8":
            print (buttonName);
            break;
	case "9":
            print (buttonName);
            break;
	case "10":
            print (buttonName);
            break;
        default:
            print ("Error");
            break;
        }
    }
}