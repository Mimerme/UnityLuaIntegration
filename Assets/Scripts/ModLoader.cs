using UnityEngine;
using System.Collections;
using System.IO;

public class ModLoader : MonoBehaviour {
	//Path where modscripts are located
	public string modScripts = @"c:\LinkMods";
	ArrayList Mods = new ArrayList();
//Loads Mods outside of Excecutable
	void Start(){
		Directory.CreateDirectory (modScripts);
		//Get file list in modScripts path
		string[] fileList = Directory.GetFiles (modScripts);
		foreach (string file in fileList) {
			if(file.Contains(".lua")){
				Debug.Log("Loading ModScript " + file);
				Mod mod = new Mod(file);
				Mods.Add(mod);
				mod.Start();
			}
		}
		//Load all mod related code after load of all modscripts

	}
	//Just calls all the Update functions in all the lua scripts
	void Update(){
		foreach (Mod m in Mods) {
			m.Update();
		}
	}
}
