using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class MyLuaFunctions : MonoBehaviour {

    public WaterMeterController WaterMeterScript;

    void OnEnable()
    {
        Lua.RegisterFunction("change1", this, typeof(MyLuaFunctions).GetMethod("change1"));
        Lua.RegisterFunction("change2", this, typeof(MyLuaFunctions).GetMethod("change2"));
        Lua.RegisterFunction("change3", this, typeof(MyLuaFunctions).GetMethod("change3"));
        Lua.RegisterFunction("npcspoken", this, typeof(MyLuaFunctions).GetMethod("npcspoken"));


    }

    void OnDisable()
    {
        Lua.UnregisterFunction("change1");
        Lua.UnregisterFunction("change2");
        Lua.UnregisterFunction("change3");
        Lua.UnregisterFunction("npcspoken");

    }

    public void change1()
    {
        WaterMeterScript.currentDecreaseRate = WaterMeterScript.currentDecreaseRate - 1;
    }

    public void change2()
    {
        WaterMeterScript.currentDecreaseRate = WaterMeterScript.currentDecreaseRate - 2;
    }

    public void change3()
    {
        WaterMeterScript.currentDecreaseRate = WaterMeterScript.currentDecreaseRate - 3;
    }

    public void npcspoken()
    {
        WaterMeterScript.NPC_Interacted += 1;
    }
}
