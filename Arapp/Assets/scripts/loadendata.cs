using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class loadendata : MonoBehaviour {

	public float length;
	public float newLength;
	public InputField InputFieldlengte;
	public int inthoi;

	// Use this for initialization
	[System.Serializable]
	class PlayerData{
		public float length;
		public InputField InputFieldlengte;
		public int inthoi;


}
	public void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
		{
			// HIER NOG VERDER NOG NIET GOED OVERGENOMEN
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();

			length = data.length;
			InputFieldlengte = data.InputFieldlengte;

		}
	}
	public string myvariable;
	public void show()
	{
		//Debug.Log (InputFieldlengte);
		myvariable = PlayerPrefs.GetString("saveNom");
		print(myvariable);

	}
}
