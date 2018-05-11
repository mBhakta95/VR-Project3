using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchCam : MonoBehaviour {
    
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;
    public Camera cam7;
    public Camera cam8;
    public Camera MainCamera;
    public Text mercText;
    public Text venusText;
    public Text earthText;
    public Text marsText;
    public Text jupiterText;
    public Text saturnText;
    public Text uranusText;
    public Text neptuneText;

     string mercuryInfo = "Mercury \n Mass (10^24 kg)	0.330 \n Diameter (km)	4879	 \n Density (kg/m3)	5427 \n" +
        " Gravity (m/s2)	3.7	 \n Rotation Period (hours) 1407.6 \n Length of Day (hours)	 4222.6 \n Orbital Period (days)	88.0 \n" +
        " Orbital Velocity (km/s)	47.4 \n Mean Temperature (C)	167 \n Surface Pressure (atmospheres) 0 \n Number of Moons	0";
    string venusInfo = "Venus \n Mass (10^24 kg)	4.87 \n Diameter (km)	12,104 \n Density (kg/m3)	5243 \n" +
        " Gravity (m/s2)	8.9 \n Rotation Period (hours) -5832.5 \n Length of Day (hours)	 2802.0 \n Orbital Period (days)	224.7 \n" +
        " Orbital Velocity (km/s)	35.0 \n Mean Temperature (C)	464 \n Surface Pressure (atmospheres) 92 \n Number of Moons	0";
    string earthInfo = "Earth \n Mass (10^24 kg)	5.97 \n Diameter (km)	12,756 \n Density (kg/m3)	5514 \n" +
        " Gravity (m/s2)	9.8 \n Rotation Period (hours) 23.9 \n Length of Day (hours)	 24.0 \n Orbital Period (days)	365.2 \n" +
        " Orbital Velocity (km/s)	29.8 \n Mean Temperature (C)	15 \n Surface Pressure (atmospheres) 1 \n Number of Moons	1";
    string marsInfo = "Mars \n Mass (10^24 kg)	0.642 \n Diameter (km)	6792 \n Density (kg/m3)	3933 \n" +
        " Gravity (m/s2)	3.7 \n Rotation Period (hours) 24.6 \n Length of Day (hours)	 24.7 \n Orbital Period (days)	687.0 \n" +
        " Orbital Velocity (km/s)	24.1 \n Mean Temperature (C)	-65 \n Surface Pressure (atmospheres) 0.01 \n Number of Moons	2";
    string jupiterInfo = "Jupiter \n Mass (10^24 kg)	 1898 \n Diameter (km)	142,984 \n Density (kg/m3)	1326 \n" +
        " Gravity (m/s2)	23.1 \n Rotation Period (hours) 9.9 \n Length of Day (hours)	9.9 \n Orbital Period (days)	4331 \n" +
        " Orbital Velocity (km/s)	13.1 \n Mean Temperature (C)	-110\n Surface Pressure (atmospheres) Unknown \n Number of Moons	67";
    string saturnInfo = "Saturn \n Mass (10^24 kg)	 568 \n Diameter (km)	120,536 \n Density (kg/m3)	687 \n" +
        " Gravity (m/s2)	9.0 \n Rotation Period (hours) 10.7 \n Length of Day (hours)	10.7 \n Orbital Period (days)	10,747 \n" +
        " Orbital Velocity (km/s)	9.7 \n Mean Temperature (C)	-140\n Surface Pressure (atmospheres) Unknown \n Number of Moons	62";
    string uranusInfo = "Uranus \n Mass (10^24 kg)	 86.8 \n Diameter (km)	51,118 \n Density (kg/m3)	1271 \n" +
    " Gravity (m/s2)	8.7 \n Rotation Period (hours) -17.2 \n Length of Day (hours)	17.2 \n Orbital Period (days)	30,589 \n" +
    " Orbital Velocity (km/s)	6.8 \n Mean Temperature (C) 	-195\n Surface Pressure (atmospheres) Unknown \n Number of Moons	27";
    string neptuneInfo = "Neptune \n Mass (10^24 kg)	 102 \n Diameter (km)	49,528 \n Density (kg/m3)	1638 \n" +
    " Gravity (m/s2)	11.0 \n Rotation Period (hours) 16.1 \n Length of Day (hours)	16.1 \n Orbital Period (days)	59,800 \n" +
    " Orbital Velocity (km/s)	5.4 \n Mean Temperature (C) -200\n Surface Pressure (atmospheres) Unknown \n Number of Moons	14";

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKey(KeyCode.Alpha0))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            MainCamera.enabled = true;
            venusText.text = "";
            mercText.text = "";
            earthText.text = "";
            marsText.text = "";
            jupiterText.text = "";
            saturnText.text = "";
            uranusText.text = "";
            neptuneText.text = "";
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            MainCamera.enabled = false;
           mercText.text = mercuryInfo;
            venusText.text = "";
            earthText.text = "";
            marsText.text = "";
            jupiterText.text = "";
            saturnText.text = "";
            uranusText.text = "";
            neptuneText.text = "";
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            cam1.enabled = false;
            cam2.enabled = true;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            MainCamera.enabled = false;
            venusText.text = venusInfo;
            mercText.text = "";
            earthText.text = "";
            marsText.text = "";
            jupiterText.text = "";
            saturnText.text = "";
            uranusText.text = "";
            neptuneText.text = "";
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            MainCamera.enabled = false;
            mercText.text = "";
            venusText.text = "";
            earthText.text = earthInfo;
            marsText.text = "";
            jupiterText.text = "";
            saturnText.text = "";
            uranusText.text = "";
            neptuneText.text = "";
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = true;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            MainCamera.enabled = false;
            venusText.text = "";
            mercText.text = "";
            earthText.text = "";
            marsText.text = marsInfo;
            jupiterText.text = "";
            saturnText.text = "";
            uranusText.text = "";
            neptuneText.text = "";
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = true;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            MainCamera.enabled = false;
            venusText.text = "";
            mercText.text = "";
            earthText.text = "";
            marsText.text = "";
            jupiterText.text = jupiterInfo;
            saturnText.text = "";
            uranusText.text = "";
            neptuneText.text = "";
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = true;
            cam7.enabled = false;
            cam8.enabled = false;
            MainCamera.enabled = false;
            venusText.text = "";
            mercText.text = "";
            earthText.text = "";
            marsText.text = "";
            jupiterText.text = "";
            saturnText.text = saturnInfo;
            uranusText.text = "";
            neptuneText.text = "";
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = true;
            cam8.enabled = false;
            MainCamera.enabled = false;
            venusText.text = "";
            mercText.text = "";
            earthText.text = "";
            marsText.text = "";
            jupiterText.text = "";
            saturnText.text = "";
            uranusText.text = uranusInfo;
            neptuneText.text = "";
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = true;
            MainCamera.enabled = false;
            venusText.text = "";
            mercText.text = "";
            earthText.text = "";
            marsText.text = "";
            jupiterText.text = "";
            saturnText.text = "";
            uranusText.text = "";
            neptuneText.text = neptuneInfo;
        }
    }
}
