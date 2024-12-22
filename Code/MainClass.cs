using NeoModLoader.api;

namespace Mess_Box.Code
{
    public class MainClass : BasicMod<MainClass>
    {
        protected override void OnModLoad()
        {
            // Load your mod here
            // 加载你的mod内容
            // LogInfo(GetConfig()["Default"]["WhatToSay"].TextVal); // Call this only then you confirm it is a text config item
            LogInfo(GetConfig()["Default"]["WhatToSay"].GetValue() as string);
        }
    }
}