using UnityEngine;
using System.Collections;
using UnityEditor;
public class EditorCommon : MonoBehaviour {

	[MenuItem ("Tuong/Clear All Prefs")]
	static void ClearPrefs () {
		PlayerPrefs.DeleteAll ();
		Debug.Log ("Clear all Prefabs success");
	}
}
