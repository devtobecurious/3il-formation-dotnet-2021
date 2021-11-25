
using GameProject;

Setting setting = new ();
setting.NbRows = 1;


Game? game = new Game(new Setting() { NbColumns = 20, NbRows = 20 });
game.Start();