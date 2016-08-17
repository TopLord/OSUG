using UnityEngine;
using System.Collections;

/// <summary>
/// Item tag.
/// automatically sets up item tags
/// </summary>
namespace S1
{
	public class Item_Tag : MonoBehaviour {

		public string itemTag;

		void OnEnable() {

			SetTag ();
		
		}

		void OnDisable() {
			
		
		}

		void SetTag(){

			if (itemTag == "") {
				itemTag = "Untagged";
			}

			transform.tag = itemTag;
		}
	}
}
