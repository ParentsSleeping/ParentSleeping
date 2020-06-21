using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;


	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;

	//	fill.color = gradient.Evaluate(1f);
	}

private void Update() {
	Debug.Log("update");
	slider.value = slider.value;
}
    public void SetHealth(int health)
	{
		slider.value = health;

	//	fill.color = gradient.Evaluate(slider.normalizedValue);
	}
}









// public sealed class Singleton
//     {
//     private Singleton()
//     {
//     }

//     public static Singleton Instance { get { return HealthBar.instance; } }

//     private class HealthBar : MonoBehaviour
//     {
// 		public Slider slider;
// 		public Gradient gradient;
//     // Explicit static constructor to tell C# compiler
//     // not to mark type as beforefieldinit
//     static HealthBar()
//     {

//     }
// 	public void SetMaxHealth(int health)
// 	{
// 		slider.maxValue = health;
// 		slider.value = health;

// 	//	fill.color = gradient.Evaluate(1f);
// 	}

// 	// private void Update() {
// 	// Debug.Log("update");
// 	// slider.value = slider.value;
// 	// }


//     public void SetHealth(int health)
// 	{
// 		slider.value = health;

// 	//	fill.color = gradient.Evaluate(slider.normalizedValue);
// 	}

//     internal static readonly HealthBar instance = new HealthBar();
//     }
//     }
























