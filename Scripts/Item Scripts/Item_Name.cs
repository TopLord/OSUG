using UnityEngine;
using System.Collections;

/// <summary>
/// Item name.
/// Gives Item a name when Item is enabled
/// </summary>
namespace S1
{
	public class Item_Name : MonoBehaviour {
		
		public string itemName;

		void Start() {

			SetItemName ();
		
		}

		void SetItemName(){
			transform.name = itemName;
		}
	}
}
