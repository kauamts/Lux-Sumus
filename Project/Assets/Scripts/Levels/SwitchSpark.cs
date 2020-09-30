﻿using UnityEngine;
using System.Collections;

public class SwitchSpark : MonoBehaviour
{
	public Switch trigger_01;
	public SwitchLine line_01;
	public Material corAtivada;
	public Material corDesativada;

	void Start ()
	{
		
	}
	
	void Update ()
	{
		if(trigger_01.ativada)
		{
			gameObject.renderer.material = corAtivada;
			line_01.hasJuice = true;
		}
		else
		{
			gameObject.renderer.material = corDesativada;
			line_01.hasJuice = false;
		}
	}

}