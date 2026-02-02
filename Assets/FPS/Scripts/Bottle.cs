using System;
using System.Net.NetworkInformation;
using UnityEngine;

namespace AH2721
{
	public class Bottle : MonoBehaviour
	{
		public Material bottleMaterial;
		public string bottleContents;
		[Range(0.0f,1.0f)]
		public float liquidAmount;

		private float minimumLiquidCapacity = 0.0f;
		private float maximumLiquidCapacity = 1.0f;

		public bool isCapOn = true;
		public void ChangeLiquidAmount(float changeAmount)
		{
			//TODO: Change the amount of liquid and safeguard against going below or over the capacity of the bottle
		}
	} 
}
