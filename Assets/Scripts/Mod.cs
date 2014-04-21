using UnityEngine;
using System.Collections;
using LuaInterface;

public class Mod{
	//Reference to the Lua virtual machine
	private Lua luaVirtualMachine;

	//A binding is something where the lua script can acess a C# class
	public LuaBinding binding = new LuaBinding();
	public GameBinding gameBinding = new GameBinding();

	public string LuaFileToLoad = "";

	//Create new instance of lua virtual machine for mod
	//May use same instance of virtual machine in future updates
	public Mod(string LuaFile){
		LuaFileToLoad = LuaFile;
		}

	public void Start(){

		//Init instance of Lua virtual machine (Note: Can only init ONCE)
		luaVirtualMachine = new Lua();
		//Tell Lua about the LuaBinding object to allow Lua to call C# functions
		luaVirtualMachine["luabinding"] = binding;
		luaVirtualMachine["gameBinding"] = gameBinding;
		//Run the code contained within the file
		luaVirtualMachine.DoFile(LuaFileToLoad);		
		//Trigger binding in c# to call the bound Lua function
		binding.RunStart();
	}
	public void Update(){
		binding.CallUpdate ();
		}
}
