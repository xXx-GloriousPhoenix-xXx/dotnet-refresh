using REFRESH.GoF.Structural._02_Bridge;

var tv = new TV();
var remote = new AdvancedRemote(tv);
remote.Mute();