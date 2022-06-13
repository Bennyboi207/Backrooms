using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashlight : MonoBehaviour
{
	public GameObject light;
	private bool FlashlightActive = false;
	public Slider batterybar;
	public float batteryLife;
	public float maxBatteryLife;
	public float bValue;

	void Start()
	{
		light.gameObject.SetActive(false);

		maxBatteryLife = batteryLife;
		batterybar.maxValue = maxBatteryLife;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.F))
		{
			light.gameObject.SetActive(true);
			FlashlightActive = true;
			batteryLife -= bValue = Time.deltaTime; 
		}
		else if (Input.GetKey(KeyCode.G))
		{
			light.gameObject.SetActive(false);
			FlashlightActive = false;
			batteryLife += bValue = Time.deltaTime;
		}

		if (batteryLife <= 0)
		{
			light.gameObject.SetActive(false);
		}

		batterybar.value = batteryLife;

	}





}
