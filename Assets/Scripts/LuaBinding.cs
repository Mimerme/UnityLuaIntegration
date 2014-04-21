using UnityEngine;
using System.Collections;
using LuaInterface; //Reference the LuaInterface DLL

public class LuaBinding  {
	public static ArrayList mods = new ArrayList();
	//Lua Functions to call
	public LuaFunction startFunc;
	public LuaFunction updateFunc;



	//Default methods modders can acess
	//RECOMENDED: DO NOT MODIFY CODE BELLOW THIS LINE
	public void BindFunc(LuaFunction start, LuaFunction update){
		//Binding	
		startFunc = start;	
		updateFunc = update;	
	}
	//Calls the UpdateFcuntion every frame in Lua Script
	public void CallUpdate(){
		updateFunc.Call ();
		}
	//Calls the StartFunction in Lua Script
	public void RunStart(){
				startFunc.Call ();
		}
	//Log data to Unity Debug Console from Lua script
	public void Log(string message){
		//Output message into the debug log
		Debug.Log(message);
	}
	//Add mod data from lua script. Uses ModInfo.cs. Not necessary,but recommended
	public void AddMod(string name, string version, string description){
		mods.Add(new ModInfo(name, version, description));
	}
}
