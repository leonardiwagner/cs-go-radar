# cs-go-radar
A mod for CS:GO, where you can adjust colors and sizes for a better visualization.

**Important:** this project doesn't make any changes in the game at all (such as writting on game's memory), it only displays an overlay over the running game. The intent of this project is for academic purpose to research how could I customize the game (modding), and I'm posting here for academical purposes and knowledge share. Althought it can be potentially used for cheating purposes I'm not distribuiting or encouraging to use this as a cheat. It's only a source code and I'm not responsible for the third party users.

Demo:

![Example image of CS:GO radar](https://github.com/leonardiwagner/cs-go-radar/blob/master/demo.jpg?raw=true)

How to use:

- Open CS:GO and wait until it show the game on screen
- Ensure that you are using Fullscreen Windowed or Windowed video mode in game Video Options.
- Open this Mod
- Click on Start on the mod. (Yes, you can start or stop without needing open/close the game!)
- Use mod tweaks to adust the position on radar. There are alredy presets which works with 800x600 and 1024x768 resolutions, check `frmRadar.cs` file. My best approach to adjust to your ideal numbers is start a game with bots use `sv_cheats 1` and `bot_stop 1` to make them stop, place them on random positions in the map with `bot_place` and align the mod positions into game's radar position. Note if you use streched mode, the alignment will be good only when you are facing the other player due streched nature.
- Ensure that you are using these radar configurations on CS:GO:
```
cl_radar_always_centered 1
cl_radar_rotate 1
```

The default presets are using `cl_hud_radar_scale 1.3` and `cl_radar_scale 0.5` (only for Cobblestone map is: `cl_radar_scale 0.7`)
