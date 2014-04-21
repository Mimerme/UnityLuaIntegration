using System.Collections;

public class ModInfo{
	//Object is stored in ArrayList as a list of Mods, not really necessary, but just felt like adding it in
	public string name;
	public string version;
	public string description;

	public ModInfo(string n, string v, string d){
		name = n;
		version = v;
		description = d;
		}
	public string GetName(){
		return name;
	}
	public string GetVersion(){
		return version;
	}
	public string GetDescription(){
		return description;
	}
	public string GetInfo(){
		return("Name: " + name + " Version: " + version + " Description: " + description);

	 }
}
