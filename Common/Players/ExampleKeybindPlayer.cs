using TerrariaHbM.Common.Systems;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaHbM.Common.Players
{
	// See Common/Systems/KeybindSystem for keybind registration.
	public class ExampleKeybindPlayer : ModPlayer
	{
		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (KeybindSystem.RandomBuffKeybind.JustPressed)
			{
				int buff = Main.rand.Next(BuffID.Count);
				Player.AddBuff(buff, 600);
				Main.NewText($"TerrariaHbM's ModKeybind was just pressed. The {Lang.GetBuffName(buff)} buff was given to the player.");
			}
		}
	}
}
